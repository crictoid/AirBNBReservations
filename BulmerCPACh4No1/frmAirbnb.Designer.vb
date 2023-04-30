<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirbnb
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picAirbnb = New System.Windows.Forms.PictureBox()
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(669, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 28)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(545, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 28)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.Silver
        Me.btnCost.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(421, 366)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(116, 28)
        Me.btnCost.TabIndex = 17
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(665, 244)
        Me.lblTotalCost.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(67, 19)
        Me.lblTotalCost.TabIndex = 16
        Me.lblTotalCost.Text = "$888.88"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(486, 244)
        Me.lblTotalLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(99, 19)
        Me.lblTotalLabel.TabIndex = 15
        Me.lblTotalLabel.Text = "Cost of Stay:"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(669, 189)
        Me.txtNumberOfDays.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(37, 27)
        Me.txtNumberOfDays.TabIndex = 14
        Me.txtNumberOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDays.Location = New System.Drawing.Point(486, 193)
        Me.lblNumberOfDays.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(146, 19)
        Me.lblNumberOfDays.TabIndex = 13
        Me.lblNumberOfDays.Text = "Number of Nights:"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(518, 111)
        Me.lblCostHeading.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(188, 20)
        Me.lblCostHeading.TabIndex = 12
        Me.lblCostHeading.Text = "Only $XX.XX per night"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(484, 45)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(276, 36)
        Me.lblHeading.TabIndex = 11
        Me.lblHeading.Text = "Orlando AirBnB"
        '
        'picAirbnb
        '
        Me.picAirbnb.Image = Global.BulmerCPACh4No1.My.Resources.Resources.airbnb
        Me.picAirbnb.Location = New System.Drawing.Point(-4, -2)
        Me.picAirbnb.Margin = New System.Windows.Forms.Padding(5)
        Me.picAirbnb.Name = "picAirbnb"
        Me.picAirbnb.Size = New System.Drawing.Size(407, 452)
        Me.picAirbnb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirbnb.TabIndex = 10
        Me.picAirbnb.TabStop = False
        '
        'frmAirbnb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picAirbnb)
        Me.Name = "frmAirbnb"
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCost As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents picAirbnb As PictureBox
End Class
