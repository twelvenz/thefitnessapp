namespace FitnessApp
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnChest = new System.Windows.Forms.Button();
            this.btnLeg = new System.Windows.Forms.Button();
            this.btnArms = new System.Windows.Forms.Button();
            this.btnShoulder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAb = new System.Windows.Forms.Button();
            this.fitnessExercisesDataSet = new FitnessApp.FitnessExercisesDataSet();
            this.exercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exercisesTableAdapter = new FitnessApp.FitnessExercisesDataSetTableAdapters.ExercisesTableAdapter();
            this.tableAdapterManager = new FitnessApp.FitnessExercisesDataSetTableAdapters.TableAdapterManager();
            this.exercisesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.exercisesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.exercisesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessExercisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingNavigator)).BeginInit();
            this.exercisesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChest
            // 
            this.btnChest.Location = new System.Drawing.Point(249, 172);
            this.btnChest.Name = "btnChest";
            this.btnChest.Size = new System.Drawing.Size(188, 72);
            this.btnChest.TabIndex = 0;
            this.btnChest.Text = "Chest";
            this.btnChest.UseVisualStyleBackColor = true;
            this.btnChest.Click += new System.EventHandler(this.btnChest_Click);
            // 
            // btnLeg
            // 
            this.btnLeg.Location = new System.Drawing.Point(568, 172);
            this.btnLeg.Name = "btnLeg";
            this.btnLeg.Size = new System.Drawing.Size(188, 72);
            this.btnLeg.TabIndex = 1;
            this.btnLeg.Text = "Leg";
            this.btnLeg.UseVisualStyleBackColor = true;
            this.btnLeg.Click += new System.EventHandler(this.btnLeg_Click);
            // 
            // btnArms
            // 
            this.btnArms.Location = new System.Drawing.Point(249, 300);
            this.btnArms.Name = "btnArms";
            this.btnArms.Size = new System.Drawing.Size(188, 72);
            this.btnArms.TabIndex = 2;
            this.btnArms.Text = "Arms";
            this.btnArms.UseVisualStyleBackColor = true;
            this.btnArms.Click += new System.EventHandler(this.btnArms_Click);
            // 
            // btnShoulder
            // 
            this.btnShoulder.Location = new System.Drawing.Point(568, 300);
            this.btnShoulder.Name = "btnShoulder";
            this.btnShoulder.Size = new System.Drawing.Size(188, 72);
            this.btnShoulder.TabIndex = 3;
            this.btnShoulder.Text = "Shoulder";
            this.btnShoulder.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(249, 437);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 72);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAb
            // 
            this.btnAb.Location = new System.Drawing.Point(568, 437);
            this.btnAb.Name = "btnAb";
            this.btnAb.Size = new System.Drawing.Size(188, 72);
            this.btnAb.TabIndex = 5;
            this.btnAb.Text = "Ab";
            this.btnAb.UseVisualStyleBackColor = true;
            // 
            // fitnessExercisesDataSet
            // 
            this.fitnessExercisesDataSet.DataSetName = "FitnessExercisesDataSet";
            this.fitnessExercisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exercisesBindingSource
            // 
            this.exercisesBindingSource.DataMember = "Exercises";
            this.exercisesBindingSource.DataSource = this.fitnessExercisesDataSet;
            // 
            // exercisesTableAdapter
            // 
            this.exercisesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExercisesTableAdapter = this.exercisesTableAdapter;
            this.tableAdapterManager.UpdateOrder = FitnessApp.FitnessExercisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exercisesBindingNavigator
            // 
            this.exercisesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.exercisesBindingNavigator.BindingSource = this.exercisesBindingSource;
            this.exercisesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.exercisesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.exercisesBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.exercisesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.exercisesBindingNavigatorSaveItem});
            this.exercisesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.exercisesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.exercisesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.exercisesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.exercisesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.exercisesBindingNavigator.Name = "exercisesBindingNavigator";
            this.exercisesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.exercisesBindingNavigator.Size = new System.Drawing.Size(2142, 42);
            this.exercisesBindingNavigator.TabIndex = 6;
            this.exercisesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 19);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // exercisesBindingNavigatorSaveItem
            // 
            this.exercisesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exercisesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("exercisesBindingNavigatorSaveItem.Image")));
            this.exercisesBindingNavigatorSaveItem.Name = "exercisesBindingNavigatorSaveItem";
            this.exercisesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.exercisesBindingNavigatorSaveItem.Text = "Save Data";
            this.exercisesBindingNavigatorSaveItem.Click += new System.EventHandler(this.exercisesBindingNavigatorSaveItem_Click);
            // 
            // exercisesDataGridView
            // 
            this.exercisesDataGridView.AutoGenerateColumns = false;
            this.exercisesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exercisesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.exercisesDataGridView.DataSource = this.exercisesBindingSource;
            this.exercisesDataGridView.Location = new System.Drawing.Point(905, 152);
            this.exercisesDataGridView.Name = "exercisesDataGridView";
            this.exercisesDataGridView.RowHeadersWidth = 82;
            this.exercisesDataGridView.RowTemplate.Height = 33;
            this.exercisesDataGridView.Size = new System.Drawing.Size(1071, 220);
            this.exercisesDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Force";
            this.dataGridViewTextBoxColumn3.HeaderText = "Force";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Level";
            this.dataGridViewTextBoxColumn4.HeaderText = "Level";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mechanic";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mechanic";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Equipment";
            this.dataGridViewTextBoxColumn6.HeaderText = "Equipment";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PrimaryMuscles";
            this.dataGridViewTextBoxColumn7.HeaderText = "PrimaryMuscles";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Instructions";
            this.dataGridViewTextBoxColumn8.HeaderText = "Instructions";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn9.HeaderText = "Category";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2142, 657);
            this.Controls.Add(this.exercisesDataGridView);
            this.Controls.Add(this.exercisesBindingNavigator);
            this.Controls.Add(this.btnAb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShoulder);
            this.Controls.Add(this.btnArms);
            this.Controls.Add(this.btnLeg);
            this.Controls.Add(this.btnChest);
            this.Name = "main";
            this.Text = "Fitness App";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessExercisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingNavigator)).EndInit();
            this.exercisesBindingNavigator.ResumeLayout(false);
            this.exercisesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChest;
        private System.Windows.Forms.Button btnLeg;
        private System.Windows.Forms.Button btnArms;
        private System.Windows.Forms.Button btnShoulder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAb;
        private FitnessExercisesDataSet fitnessExercisesDataSet;
        private System.Windows.Forms.BindingSource exercisesBindingSource;
        private FitnessExercisesDataSetTableAdapters.ExercisesTableAdapter exercisesTableAdapter;
        private FitnessExercisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator exercisesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton exercisesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView exercisesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

