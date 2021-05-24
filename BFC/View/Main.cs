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

        private readonly SortedDictionary<int, FoodList> _products;

        private readonly EntityManager _entityManager;
        public SortedDictionary<string, int> UserCache { get; set; }
        public Main()
        {
            _entityManager = new EntityManager();
            //Это заглушка
            _products = new SortedDictionary<int, FoodList>
            {
                [0] = new FoodList
                {
                    Name = "Банан",
                    Proteins = 0,
                    Fats = 30,
                    Carbohydrates = 20,
                    Calories = 260
                }
            };
            //--конец заглушки

            InitializeComponent();
            InitializeActivityCombobox();
            InitializePlanCombobox();
            InitializeProducts();
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
            var bindingSource = new BindingSource
            {
                DataSource = _products
            };

            ProductsCombobox.DataSource = bindingSource;
            ProductsCombobox.DisplayMember = "Value.Name";

            //ИЗМЕНИ ЭТО ПОЛЕ НА ID ПОСЛЕ ТОГО КАК ДОБАВИШЬ ПОДКЛЮЧЕНИЕ К БД!!!
            ProductsCombobox.ValueMember = "Proteins";//<<<===ВОТ ТУТ
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        }



        private void AddProductButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct();
            addProductForm.ShowDialog();
        }

        /// <summary>
        /// Вычисление по заданным параметрам и вывод результата
        /// </summary>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var sex = MaleRadioButton.Checked;
            var age = double.Parse(AgeInput.Text);
            var weight = double.Parse(WeightInput.Text);
            var height = double.Parse(HeightInput.Text);
            var activity = (Activity)ActivityCombobox.SelectedIndex;
            var plan = (Plan)PlanCombobox.SelectedIndex;
            var formula = GetChoosenFormula();

            ResutlOutput.Text = Calculate.GetCalculateCalories(sex, age, weight, height, activity, plan, formula);
        }

        private EFormula GetChoosenFormula()
        {   //очень узкий метод. К нему следует относиться с осторожностью
            if(FirstFormulaRB.Checked)
            {
                return EFormula.MifflinSanGeora;
            }
            else
            {
                return EFormula.HarrisBenedict;
            }
        }

        private void ProductCalculateButton_Click(object sender, EventArgs e)
        {
            var product = ProductsCombobox.SelectedIndex;
            var weight = double.Parse(ProductWeightInput.Text);
            var calories = (double)_products[product].Calories;

            var result = Calculate.GetProductCalories(weight, calories);
            ProductResultOutput.Text = result;
        }

        private void ProductsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = ProductsCombobox.SelectedIndex;

            CaloriesOutput.Text = _products[product].Calories.ToString();
            ProteinsOutput.Text = _products[product].Proteins.ToString();
            FatsOutput.Text = _products[product].Fats.ToString();
            CarboOutput.Text = _products[product].Carbohydrates.ToString();
        }
    }
}
