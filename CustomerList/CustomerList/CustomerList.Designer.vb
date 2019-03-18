<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.cmbMakes = New System.Windows.Forms.ComboBox()
        Me.lbMake = New System.Windows.Forms.Label()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.cmbYears = New System.Windows.Forms.ComboBox()
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(127, 561)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "&Enter"
        Me.CustomerToolTip.SetToolTip(Me.btnEnter, "Click to add a customer.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(235, 561)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset"
        Me.CustomerToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(343, 561)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.CustomerToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(112, 42)
        Me.tbModel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(160, 22)
        Me.tbModel.TabIndex = 3
        Me.CustomerToolTip.SetToolTip(Me.tbModel, "Type the customer's first name here.")
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(112, 114)
        Me.tbPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(160, 22)
        Me.tbPrice.TabIndex = 5
        Me.CustomerToolTip.SetToolTip(Me.tbPrice, "Type the customer's last name here.")
        '
        'cmbMakes
        '
        Me.cmbMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMakes.FormattingEnabled = True
        Me.cmbMakes.Items.AddRange(New Object() {"Mr.", "Mrs.", "Miss.", "Ms.", "Mstr.", "Dr."})
        Me.cmbMakes.Location = New System.Drawing.Point(112, 9)
        Me.cmbMakes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMakes.Name = "cmbMakes"
        Me.cmbMakes.Size = New System.Drawing.Size(160, 24)
        Me.cmbMakes.TabIndex = 1
        Me.CustomerToolTip.SetToolTip(Me.cmbMakes, "Select the customer's title.")
        '
        'lbMake
        '
        Me.lbMake.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbMake.Location = New System.Drawing.Point(16, 9)
        Me.lbMake.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMake.Name = "lbMake"
        Me.lbMake.Size = New System.Drawing.Size(88, 16)
        Me.lbMake.TabIndex = 0
        Me.lbMake.Text = "&Make:"
        Me.lbMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbModel
        '
        Me.lbModel.Location = New System.Drawing.Point(16, 42)
        Me.lbModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(88, 16)
        Me.lbModel.TabIndex = 2
        Me.lbModel.Text = "Mo&del:"
        Me.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbModel.UseWaitCursor = True
        '
        'lbPrice
        '
        Me.lbPrice.Location = New System.Drawing.Point(16, 120)
        Me.lbPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(88, 16)
        Me.lbPrice.TabIndex = 4
        Me.lbPrice.Text = "&Price:"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(68, 144)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(61, 30)
        Me.chkNew.TabIndex = 6
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustomerToolTip.SetToolTip(Me.chkNew, "Check to make the customer a VIP.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.Location = New System.Drawing.Point(3, 175)
        Me.lvwCars.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(439, 302)
        Me.lvwCars.TabIndex = 7
        Me.CustomerToolTip.SetToolTip(Me.lvwCars, "Select a customer to modify.")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colPrice
        '
        Me.colPrice.DisplayIndex = 4
        Me.colPrice.Text = "Price"
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(3, 481)
        Me.lbResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(440, 74)
        Me.lbResult.TabIndex = 8
        Me.CustomerToolTip.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'lbYear
        '
        Me.lbYear.Location = New System.Drawing.Point(53, 84)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(100, 23)
        Me.lbYear.TabIndex = 12
        Me.lbYear.Text = "&Year:"
        '
        'cmbYears
        '
        Me.cmbYears.FormattingEnabled = True
        Me.cmbYears.Location = New System.Drawing.Point(112, 77)
        Me.cmbYears.Name = "cmbYears"
        Me.cmbYears.Size = New System.Drawing.Size(160, 24)
        Me.cmbYears.TabIndex = 13
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(445, 596)
        Me.Controls.Add(Me.cmbYears)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbModel)
        Me.Controls.Add(Me.lbMake)
        Me.Controls.Add(Me.cmbMakes)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbModel As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents cmbMakes As ComboBox
    Friend WithEvents lbMake As Label
    Friend WithEvents lbModel As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents CustomerToolTip As ToolTip
    Friend WithEvents lbResult As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents cmbYears As ComboBox
    Friend WithEvents colYear As ColumnHeader
End Class
