<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CelestialCoffee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CelestialCoffee))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEnterAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblRegCoffee = New System.Windows.Forms.Label()
        Me.lblDecCoffee = New System.Windows.Forms.Label()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtRegular = New System.Windows.Forms.TextBox()
        Me.txtDecaf = New System.Windows.Forms.TextBox()
        Me.picCoffee = New System.Windows.Forms.PictureBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblStreetCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(491, 53)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Welcome to Celestial Coffee!"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(20, 62)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(429, 31)
        Me.lblOrder.TabIndex = 1
        Me.lblOrder.Text = "Enter the Following to Place Your Order:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(98, 116)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 25)
        Me.txtFirstName.TabIndex = 2
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterName.Location = New System.Drawing.Point(15, 112)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(77, 31)
        Me.lblEnterName.TabIndex = 3
        Me.lblEnterName.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'lblEnterAddress
        '
        Me.lblEnterAddress.AutoSize = True
        Me.lblEnterAddress.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterAddress.Location = New System.Drawing.Point(16, 169)
        Me.lblEnterAddress.Name = "lblEnterAddress"
        Me.lblEnterAddress.Size = New System.Drawing.Size(81, 27)
        Me.lblEnterAddress.TabIndex = 5
        Me.lblEnterAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(98, 172)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(180, 25)
        Me.txtAddress.TabIndex = 6
        '
        'lblRegCoffee
        '
        Me.lblRegCoffee.AutoSize = True
        Me.lblRegCoffee.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCoffee.Location = New System.Drawing.Point(16, 238)
        Me.lblRegCoffee.Name = "lblRegCoffee"
        Me.lblRegCoffee.Size = New System.Drawing.Size(299, 27)
        Me.lblRegCoffee.TabIndex = 7
        Me.lblRegCoffee.Text = "Pounds of Regular Coffee Desired:"
        '
        'lblDecCoffee
        '
        Me.lblDecCoffee.AutoSize = True
        Me.lblDecCoffee.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecCoffee.Location = New System.Drawing.Point(16, 277)
        Me.lblDecCoffee.Name = "lblDecCoffee"
        Me.lblDecCoffee.Size = New System.Drawing.Size(278, 27)
        Me.lblDecCoffee.TabIndex = 8
        Me.lblDecCoffee.Text = "Pounds of Decaf Coffee Desired:"
        '
        'lstTotal
        '
        Me.lstTotal.BackColor = System.Drawing.Color.Peru
        Me.lstTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstTotal.Font = New System.Drawing.Font("Segoe Script", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotal.ForeColor = System.Drawing.Color.White
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.ItemHeight = 25
        Me.lstTotal.Location = New System.Drawing.Point(21, 388)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(668, 75)
        Me.lstTotal.TabIndex = 9
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Sienna
        Me.btnEnter.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(21, 319)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(116, 40)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtRegular
        '
        Me.txtRegular.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegular.Location = New System.Drawing.Point(326, 239)
        Me.txtRegular.Name = "txtRegular"
        Me.txtRegular.Size = New System.Drawing.Size(149, 25)
        Me.txtRegular.TabIndex = 11
        '
        'txtDecaf
        '
        Me.txtDecaf.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecaf.Location = New System.Drawing.Point(326, 280)
        Me.txtDecaf.Name = "txtDecaf"
        Me.txtDecaf.Size = New System.Drawing.Size(149, 25)
        Me.txtDecaf.TabIndex = 12
        '
        'picCoffee
        '
        Me.picCoffee.Image = CType(resources.GetObject("picCoffee.Image"), System.Drawing.Image)
        Me.picCoffee.Location = New System.Drawing.Point(495, 71)
        Me.picCoffee.Name = "picCoffee"
        Me.picCoffee.Size = New System.Drawing.Size(208, 288)
        Me.picCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCoffee.TabIndex = 13
        Me.picCoffee.TabStop = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(295, 116)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(180, 25)
        Me.txtLastName.TabIndex = 14
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(295, 172)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(62, 25)
        Me.txtState.TabIndex = 15
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Segoe Script", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(375, 172)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 25)
        Me.txtZip.TabIndex = 16
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.Color.White
        Me.lblFirst.Location = New System.Drawing.Point(159, 142)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(59, 20)
        Me.lblFirst.TabIndex = 17
        Me.lblFirst.Text = "(FIRST)"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.ForeColor = System.Drawing.Color.White
        Me.lblLast.Location = New System.Drawing.Point(359, 142)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(56, 20)
        Me.lblLast.TabIndex = 18
        Me.lblLast.Text = "(LAST)"
        '
        'lblStreetCity
        '
        Me.lblStreetCity.AutoSize = True
        Me.lblStreetCity.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetCity.ForeColor = System.Drawing.Color.White
        Me.lblStreetCity.Location = New System.Drawing.Point(125, 200)
        Me.lblStreetCity.Name = "lblStreetCity"
        Me.lblStreetCity.Size = New System.Drawing.Size(116, 20)
        Me.lblStreetCity.TabIndex = 19
        Me.lblStreetCity.Text = "(STREET, CITY)"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(294, 202)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(65, 20)
        Me.lblState.TabIndex = 20
        Me.lblState.Text = "(STATE)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(380, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "(ZIP CODE)"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Sienna
        Me.btnClear.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(26, 462)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 40)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Sienna
        Me.btnExit.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(177, 462)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 39)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'CelestialCoffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(715, 513)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblStreetCity)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.picCoffee)
        Me.Controls.Add(Me.txtDecaf)
        Me.Controls.Add(Me.txtRegular)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.lblDecCoffee)
        Me.Controls.Add(Me.lblRegCoffee)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblEnterAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEnterName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "CelestialCoffee"
        Me.Text = "CelestialCoffee"
        CType(Me.picCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblEnterName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEnterAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblRegCoffee As Label
    Friend WithEvents lblDecCoffee As Label
    Friend WithEvents lstTotal As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtRegular As TextBox
    Friend WithEvents txtDecaf As TextBox
    Friend WithEvents picCoffee As PictureBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblStreetCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
