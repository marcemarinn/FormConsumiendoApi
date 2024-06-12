using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Helpers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        //private Characters _characters;
        //private CharacterController _characterController;
        public Form1()
        {
            InitializeComponent();
            //_characterController = new CharacterController();
            //_characters = new Characters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvCharacters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void GetCharacters()
        {
            //_characters = await
            //   _characterController.GetAllCharacters();

            var characters = await ClientHelper.Get<Characters>("https://rickandmortyapi.com/api/character");

            if (characters != null)
            {
                foreach (var character in characters.Results)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvCharacters);
                    row.Cells[0].Value = character.name;
                    row.Cells[1].Value = character.gender;
                    row.Cells[2].Value = character.species;
                    row.Cells[3].Value = character.origin.name;
                    dgvCharacters.Rows.Add(row);

                }
            }

            else
            {
                MessageBox.Show("No se pudo obtener la pericion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCharacters();
        }
    }
}
