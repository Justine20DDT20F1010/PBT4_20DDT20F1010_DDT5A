<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Btn_Previous = New System.Windows.Forms.Button()
        Me.Btn_Last = New System.Windows.Forms.Button()
        Me.Tb_Menu = New System.Windows.Forms.TextBox()
        Me.Tb_Address = New System.Windows.Forms.TextBox()
        Me.Tb_Name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_First = New System.Windows.Forms.Button()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SystemOrderingDataSet1 = New PBT4_20DDT20F1010.SystemOrderingDataSet1()
        Me.OrderDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetailTableAdapter = New PBT4_20DDT20F1010.SystemOrderingDataSet1TableAdapters.OrderDetailTableAdapter()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemOrderingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Clear.Location = New System.Drawing.Point(429, 345)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Clear.TabIndex = 37
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Location = New System.Drawing.Point(271, 269)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Add.TabIndex = 35
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.Location = New System.Drawing.Point(271, 307)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Update.TabIndex = 34
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.Location = New System.Drawing.Point(271, 345)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Delete.TabIndex = 33
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.Location = New System.Drawing.Point(429, 307)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Exit.TabIndex = 31
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Btn_Previous
        '
        Me.Btn_Previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Previous.Location = New System.Drawing.Point(103, 345)
        Me.Btn_Previous.Name = "Btn_Previous"
        Me.Btn_Previous.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Previous.TabIndex = 30
        Me.Btn_Previous.Text = "Previous"
        Me.Btn_Previous.UseVisualStyleBackColor = True
        '
        'Btn_Last
        '
        Me.Btn_Last.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Last.Location = New System.Drawing.Point(103, 307)
        Me.Btn_Last.Name = "Btn_Last"
        Me.Btn_Last.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Last.TabIndex = 29
        Me.Btn_Last.Text = "Last Record"
        Me.Btn_Last.UseVisualStyleBackColor = True
        '
        'Tb_Menu
        '
        Me.Tb_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Menu.Location = New System.Drawing.Point(216, 208)
        Me.Tb_Menu.Name = "Tb_Menu"
        Me.Tb_Menu.Size = New System.Drawing.Size(348, 29)
        Me.Tb_Menu.TabIndex = 28
        '
        'Tb_Address
        '
        Me.Tb_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Address.Location = New System.Drawing.Point(216, 171)
        Me.Tb_Address.Name = "Tb_Address"
        Me.Tb_Address.Size = New System.Drawing.Size(348, 29)
        Me.Tb_Address.TabIndex = 27
        '
        'Tb_Name
        '
        Me.Tb_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Name.Location = New System.Drawing.Point(216, 132)
        Me.Tb_Name.Name = "Tb_Name"
        Me.Tb_Name.Size = New System.Drawing.Size(348, 29)
        Me.Tb_Name.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Menu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Address:"
        '
        'Tb_ID
        '
        Me.Tb_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_ID.Location = New System.Drawing.Point(216, 95)
        Me.Tb_ID.Name = "Tb_ID"
        Me.Tb_ID.Size = New System.Drawing.Size(114, 29)
        Me.Tb_ID.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Order ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(419, 31)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Trevi Cafe Food Ordering System"
        '
        'Btn_First
        '
        Me.Btn_First.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_First.Location = New System.Drawing.Point(103, 269)
        Me.Btn_First.Name = "Btn_First"
        Me.Btn_First.Size = New System.Drawing.Size(132, 32)
        Me.Btn_First.TabIndex = 19
        Me.Btn_First.Text = "First Record"
        Me.Btn_First.UseVisualStyleBackColor = True
        '
        'Btn_Next
        '
        Me.Btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Next.Location = New System.Drawing.Point(429, 269)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Next.TabIndex = 38
        Me.Btn_Next.Text = "Next"
        Me.Btn_Next.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MenuDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderDetailBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(636, 238)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 150)
        Me.DataGridView1.TabIndex = 39
        '
        'SystemOrderingDataSet1
        '
        Me.SystemOrderingDataSet1.DataSetName = "SystemOrderingDataSet1"
        Me.SystemOrderingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderDetailBindingSource
        '
        Me.OrderDetailBindingSource.DataMember = "OrderDetail"
        Me.OrderDetailBindingSource.DataSource = Me.SystemOrderingDataSet1
        '
        'OrderDetailTableAdapter
        '
        Me.OrderDetailTableAdapter.ClearBeforeFill = True
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'MenuDataGridViewTextBoxColumn
        '
        Me.MenuDataGridViewTextBoxColumn.DataPropertyName = "Menu"
        Me.MenuDataGridViewTextBoxColumn.HeaderText = "Menu"
        Me.MenuDataGridViewTextBoxColumn.Name = "MenuDataGridViewTextBoxColumn"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Orange
        Me.PictureBox1.Location = New System.Drawing.Point(636, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(445, 170)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(650, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 66)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(650, 151)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 66)
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(802, 79)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(113, 66)
        Me.PictureBox4.TabIndex = 43
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(802, 151)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 66)
        Me.PictureBox5.TabIndex = 44
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(957, 79)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(113, 66)
        Me.PictureBox6.TabIndex = 45
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Location = New System.Drawing.Point(957, 151)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(113, 66)
        Me.PictureBox7.TabIndex = 46
        Me.PictureBox7.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1093, 400)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_Previous)
        Me.Controls.Add(Me.Btn_Last)
        Me.Controls.Add(Me.Tb_Menu)
        Me.Controls.Add(Me.Tb_Address)
        Me.Controls.Add(Me.Tb_Name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tb_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_First)
        Me.Name = "Form1"
        Me.Text = "Trive Cafe"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemOrderingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Update As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_Previous As Button
    Friend WithEvents Btn_Last As Button
    Friend WithEvents Tb_Menu As TextBox
    Friend WithEvents Tb_Address As TextBox
    Friend WithEvents Tb_Name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tb_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_First As Button
    Friend WithEvents Btn_Next As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SystemOrderingDataSet1 As SystemOrderingDataSet1
    Friend WithEvents OrderDetailBindingSource As BindingSource
    Friend WithEvents OrderDetailTableAdapter As SystemOrderingDataSet1TableAdapters.OrderDetailTableAdapter
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
