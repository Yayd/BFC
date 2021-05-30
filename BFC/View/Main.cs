using BFC.Controller;
using BFC.Model;
using BFC.Model.Entities;
using BFC.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFC
{
    public partial class Main : Form
    {
        //я потратил часа 4, чтобы разобраться с resx файлами, но пока безуспешно
        //Этим придется заняться кому-то другому
        private readonly SortedDictionary<Activity, string> _activities = new SortedDictionary<Activity, string>
        {
            [Activity.none] = "Физическая нагрузка отсутствует или минимальная",
            [Activity.low] = "Тренировки средней тяжести 3 раза в неделю",
            [Activity.upperlow] = "Тренировки средней тяжести 5 раз в неделю",
            [Activity.medium] = "Интенсивные тренровки 5 раз в неделю",
            [Activity.uppermedium] = "Тренировки каждый день",
            [Activity.hight] = "Интенсивные тренировки каждый день или по 2 раза в день",
            [Activity.extrahight] = "Ежедневная нагрузка + физическая работа"
        };

        private readonly SortedDictionary<Plan, string> _plans = new SortedDictionary<Plan, string>
        {
            [Plan.loss] = "Снижение веса",
            [Plan.maintaining] = "Поддержание веса",
            [Plan.gain] = "Набор веса"
        };

        //private readonly SortedDictionary<int, FoodList> _products;//это нам не нужно

        private readonly EntityManager _entityManager;
        public IList<FoodList> _listOfProducts { get; set; }//создал ilist вместо сорт. словарика, изменил модификатор доступа, стоить обсудить опасности
        public SortedDictionary<string, int> UserCache { get; set; }
        private readonly FillInterface _foodDataBase;
        public Main()
        {
            _entityManager = new EntityManager();
            _listOfProducts = new List<FoodList> {};//создаём лист
            _foodDataBase = new FillInterface();
            //_products = _foodDataBase.FillProducts(_entityManager); //изначально (Не мной) планировалось обращаться к классу чтобы перелопатить ilist в SortedDictionary
            //_listOfProducts = _entityManager.FindAll<FoodList>();//можно реализовать так, но это не хоршо, мы пропустили контроллер.
            // = _foodDataBase.GetProductsFromDBFood(_entityManager);//используем это так
            //переместил в InitializeProducts
            InitializeComponent();
            InitializeActivityCombobox();
            InitializePlanCombobox();
            InitializeProducts();
            InitializeData();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.AddProductButton, "Добавить в список новый продукт");
        }

        private void InitializeData()
        {
            FieldController loader = new FieldController();
            Dictionary<string, string> userData = loader.ReadFields(); 
            if (userData == null)
            {
                return;
            }
            if (userData["sex: "] == "1")
            {
                MaleRadioButton.Checked = true;
            }
            else 
            {
                FemaleRadioButton.Checked = true;
            }
            AgeInput.Text = userData["age: "];
            WeightInput.Text = userData["weight: "];
            HeightInput.Text = userData["height: "];
        }
        private void InitializeActivityCombobox()
        {
            ActivityCombobox.DataSource = new BindingSource(_activities, null);
            ActivityCombobox.DisplayMember = "Value";
            ActivityCombobox.ValueMember = "Key";
        }

        private void InitializePlanCombobox()
        {
            PlanCombobox.DataSource = new BindingSource(_plans, null);
            PlanCombobox.DisplayMember = "Value";
            PlanCombobox.ValueMember = "Key";
        }

        private void InitializeProducts()
        {
            _listOfProducts = _foodDataBase.GetProductsFromDBFood(_entityManager);
            var bindingSource = new BindingSource
            {
                DataSource = _listOfProducts//заменил на ilist
            };

            ProductsCombobox.DataSource = bindingSource;
            ProductsCombobox.DisplayMember = "Value.Name";
            ProductsCombobox.ValueMember = "Id";
        }



        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct();
            addProductForm.ShowDialog();
            InitializeProducts();//добавл для обновления комбобокса с продуктами
        }

        /// <summary>
        /// Вычисление по заданным параметрам и вывод результата
        /// </summary>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if ((AgeInput.Text == "") || (WeightInput.Text == "") || (HeightInput.Text == ""))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            var sex = MaleRadioButton.Checked;
            var age = double.Parse(AgeInput.Text);
            var weight = double.Parse(WeightInput.Text);
            var height = double.Parse(HeightInput.Text);
            var activity = (Activity)ActivityCombobox.SelectedIndex;
            var plan = (Plan)PlanCombobox.SelectedIndex;
            var formula = GetChoosenFormula();
            FieldController saver = new FieldController(sex, age, weight, height);
            saver.WriteFields();
            ResutlOutput.Text = Calculate.GetCalculateCalories(sex, age, weight, height, activity, plan, formula);
        }

        private EFormula GetChoosenFormula()
        {   //очень узкий метод. К нему следует относиться с осторожностью
             return EFormula.MifflinSanGeora;
        }
        private void CalcProd()
        {
            double weight;
            if (ProductWeightInput.Text == "")
            {
                weight = 0.0;
            }
            else
            {
                weight = double.Parse(ProductWeightInput.Text);
            }
            var product = ProductsCombobox.SelectedIndex;
            var calories = (double)_listOfProducts[product].Calories;

            var result = Calculate.GetProductCalories(weight, calories);
            ProductResultOutput.Text = result;
        }
        private void ProductCalculateButton_Click(object sender, EventArgs e)
        {
            CalcProd();
        }

        private void ProductsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = ProductsCombobox.SelectedIndex;

            CaloriesOutput.Text = _listOfProducts[product].Calories.ToString();
            ProteinsOutput.Text = _listOfProducts[product].Proteins.ToString();
            FatsOutput.Text = _listOfProducts[product].Fats.ToString();
            CarboOutput.Text = _listOfProducts[product].Carbohydrates.ToString();
            CalcProd();
        }

        private void ProductResultOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductWeightInput_TextChanged(object sender, EventArgs e)
        {
            CalcProd();
        }
    }
}
