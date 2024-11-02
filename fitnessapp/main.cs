using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class main : Form
    {
        private string _connectionString;
        public main()
        {
            InitializeComponent();
            _connectionString = @"Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FitnessExercises.mdf;Integrated Security=True;";
            importExerciseJson();
        }
        
        private void importExerciseJson()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "exercises.json");

            if (!File.Exists(jsonFilePath))
            {
                MessageBox.Show("JSON file not found.");
                return;
            }

            string jsonData = File.ReadAllText(jsonFilePath);

            // Deserialize the JSON data
            List<Exercise> exercises = JsonConvert.DeserializeObject<List<Exercise>>(jsonData);
            InsertExercisesIntoDatabase(exercises);
           
        }

        private void InsertExercisesIntoDatabase(List<Exercise> exercises)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                foreach (var exercise in exercises)
                {
                    // Convert primary muscles and instructions to comma-separated strings
                    string primaryMuscles = string.Join(", ", exercise.PrimaryMuscles);
                    string instructions = string.Join(" | ", exercise.Instructions); // Use | or another delimiter to separate instructions

                    string query = "INSERT INTO Exercises (Id, Name, Level, Mechanic, Equipment, PrimaryMuscles, Instructions, Category) " +
                                   "VALUES (@Id, @Name, @Level, @Mechanic, @Equipment, @PrimaryMuscles, @Instructions, @Category)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", exercise.Id);
                        command.Parameters.AddWithValue("@Name", exercise.Name);
                        command.Parameters.AddWithValue("@Level", exercise.Level);
                        command.Parameters.AddWithValue("@Mechanic", exercise.Mechanic);
                        command.Parameters.AddWithValue("@Equipment", exercise.Equipment);
                        command.Parameters.AddWithValue("@PrimaryMuscles", primaryMuscles);
                        command.Parameters.AddWithValue("@Instructions", instructions);
                        command.Parameters.AddWithValue("@Category", exercise.Category);

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error inserting data: {ex.Message}");
                        }
                    }
                }
            }
        }

        public class Exercise
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Force { get; set; }
            public string Level { get; set; }
            public string Mechanic { get; set; }
            public string Equipment { get; set; }
            public List<string> PrimaryMuscles { get; set; } // Keep this as a List<string> for easy manipulation
            public List<string> Instructions { get; set; }   // Keep this as a List<string> for easy manipulation
            public string Category { get; set; }
        }

        private void btnChest_Click(object sender, EventArgs e)
        {
            Chest chestForm = new Chest();
            chestForm.Show();
            this.Close();
        }

        private void btnLeg_Click(object sender, EventArgs e)
        {
            Leg legForm = new Leg();
            legForm.Show();
            this.Close();
        }

        private void btnArms_Click(object sender, EventArgs e)
        {
            Arms armsForm = new Arms();
            armsForm.Show();
            this.Close();
        }

        private void exercisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.exercisesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fitnessExercisesDataSet);

        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessExercisesDataSet.Exercises' table. You can move, or remove it, as needed.
            this.exercisesTableAdapter.Fill(this.fitnessExercisesDataSet.Exercises);

        }
    }
}
