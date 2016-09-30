<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblAnnSal = New System.Windows.Forms.Label()
        Me.lblPayPeriods = New System.Windows.Forms.Label()
        Me.lblSPPP = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtAnnualSalary = New System.Windows.Forms.TextBox()
        Me.txtPayPeriods = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAnnSal
        '
        Me.lblAnnSal.Location = New System.Drawing.Point(63, 36)
        Me.lblAnnSal.Name = "lblAnnSal"
        Me.lblAnnSal.Size = New System.Drawing.Size(80, 23)
        Me.lblAnnSal.TabIndex = 0
        Me.lblAnnSal.Text = "Annual Salary:"
        '
        'lblPayPeriods
        '
        Me.lblPayPeriods.Location = New System.Drawing.Point(33, 75)
        Me.lblPayPeriods.Name = "lblPayPeriods"
        Me.lblPayPeriods.Size = New System.Drawing.Size(110, 23)
        Me.lblPayPeriods.TabIndex = 1
        Me.lblPayPeriods.Text = "Pay periods per year:"
        '
        'lblSPPP
        '
        Me.lblSPPP.Location = New System.Drawing.Point(32, 111)
        Me.lblSPPP.Name = "lblSPPP"
        Me.lblSPPP.Size = New System.Drawing.Size(111, 23)
        Me.lblSPPP.TabIndex = 2
        Me.lblSPPP.Text = "Salary per pay period:"
        '
        'lblSalary
        '
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalary.Location = New System.Drawing.Point(161, 111)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(111, 23)
        Me.lblSalary.TabIndex = 3
        '
        'txtAnnualSalary
        '
        Me.txtAnnualSalary.Location = New System.Drawing.Point(161, 36)
        Me.txtAnnualSalary.Name = "txtAnnualSalary"
        Me.txtAnnualSalary.Size = New System.Drawing.Size(111, 20)
        Me.txtAnnualSalary.TabIndex = 4
        '
        'txtPayPeriods
        '
        Me.txtPayPeriods.Location = New System.Drawing.Point(161, 75)
        Me.txtPayPeriods.Name = "txtPayPeriods"
        Me.txtPayPeriods.Size = New System.Drawing.Size(111, 20)
        Me.txtPayPeriods.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(109, 170)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(-1, 239)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(285, 23)
        Me.lblStatus.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPayPeriods)
        Me.Controls.Add(Me.txtAnnualSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblSPPP)
        Me.Controls.Add(Me.lblPayPeriods)
        Me.Controls.Add(Me.lblAnnSal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnnSal As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriods As System.Windows.Forms.Label
    Friend WithEvents lblSPPP As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents txtAnnualSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtPayPeriods As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
