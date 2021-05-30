using BFC.Controller;
using BFC.Model;
using BFC.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BFC.View
{
    public partial class AddProduct : Form
    {
        private readonly EntityManager _entityManager;
        private readonly IList<Category> _listOfCategories;
        private readonly FillInterface _controllerDataBase;
        public AddProduct()
        {
            _entityManager = new EntityManager();
            _listOfCategories = new List<Category> { };
            _controllerDataBase = new FillInterface();

            _listOfCategories = _controllerDataBase.GetProductsFromDBCategory(_entityManager);
            InitializeComponent();
            InitializeCategoryCombobox(); 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CaloriesInput.Text.Trim() == "" || FatInput.Text.Trim() == "" || CarboInput.Text.Trim() == "" || ProteinsInput.Text.Trim() == "" || NameInput.Text.Trim() == "")
            { 
                MessageBox.Show("Пожалуйста заполните все поля.");
                return;
            }


            _entityManager.SaveOrUpdate<FoodList>(_controllerDataBase.AddToDB
                (NameInput.Text.Trim(),
                Double.Parse(ProteinsInput.Text.Trim()),
                Double.Parse(FatInput.Text.Trim()),
                Double.Parse(CarboInput.Text.Trim()),
                Int32.Parse(CaloriesInput.Text.Trim()),
                _listOfCategories[CategoryComboBox.SelectedIndex])
                );

            MessageBox.Show("Продукт "+ NameInput.Text +" был успешно добавлен.");
        }

        private void InitializeCategoryCombobox()
        {
            var bindingSource = new BindingSource
            {
                DataSource = _listOfCategories
                //заменил на ilist
            };

            CategoryComboBox.DataSource = bindingSource;
            CategoryComboBox.DisplayMember = "Name";
            CategoryComboBox.ValueMember = "Id";
        }

        private void CaloriesInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(char.IsDigit(e.KeyChar)) && number != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void ProteinsInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(char.IsDigit(e.KeyChar)) && number != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void FatInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(char.IsDigit(e.KeyChar)) && number != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void CarboInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(char.IsDigit(e.KeyChar)) && number != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
