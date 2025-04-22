using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using DomainModel.Models;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        readonly IIngredientsRepository _ingredientsRepository;
        public IngredientsForm(IIngredientsRepository ingredientsRepository)
        {
            InitializeComponent();
            _ingredientsRepository = ingredientsRepository;
        }

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text, WeightNum.Value, KcalPer100gNum.Value, PricePer100gNum.Value);

            _ingredientsRepository.AddIngredient(ingredient);
            ClearAllFields();
            RefreshGridData();
        }

        private void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            TypeTxt.Text = string.Empty;
            WeightNum.Value = 1;
            KcalPer100gNum.Value = 0;
            PricePer100gNum.Value = 0;
            SearchTxt.Text = string.Empty;
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            RefreshGridData();
            CustomizeGridAppearance();
        }
        private void RefreshGridData()
        {
            IngredientsGrid.DataSource = _ingredientsRepository.GetIngredients(SearchTxt.Text);
        }

        private void CustomizeGridAppearance()
        {
            IngredientsGrid.Columns["Id"].Visible = false;
            IngredientsGrid.Columns["Name"].HeaderText = "Name";
            IngredientsGrid.Columns["Type"].HeaderText = "Type";
            IngredientsGrid.Columns["Weight"].HeaderText = "Weight (g)";
            IngredientsGrid.Columns["KcalPer100g"].HeaderText = "Kcal(100g)";
            IngredientsGrid.Columns["PricePer100g"].HeaderText = "Price (100g)";
            IngredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IngredientsGrid.AutoGenerateColumns = false;


            //IngredientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //IngredientsGrid.AutoGenerateColumns = false;
            //DataGridViewColumn[] columns = new DataGridViewColumn[6];
            //columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            //columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            //columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            //columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight (g)" };
            //columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "KcalPer100g", HeaderText = "Kcal (100g)" };
            //columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "PricePer100g", HeaderText = "Price (100g)" };
            //IngredientsGrid.Columns.Clear();
            //IngredientsGrid.Columns.AddRange(columns);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            RefreshGridData();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            RefreshGridData();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}