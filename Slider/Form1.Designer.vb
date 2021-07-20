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
        Me.trcRadius = New System.Windows.Forms.TrackBar()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        CType(Me.trcRadius, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trcRadius
        '
        Me.trcRadius.Location = New System.Drawing.Point(57, 295)
        Me.trcRadius.Maximum = 100
        Me.trcRadius.Name = "trcRadius"
        Me.trcRadius.Size = New System.Drawing.Size(1330, 114)
        Me.trcRadius.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(468, 799)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(376, 112)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(480, 624)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(353, 172)
        Me.lblOutput.TabIndex = 3
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(486, 449)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(344, 172)
        Me.txtInput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 1106)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.trcRadius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.trcRadius, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trcRadius As TrackBar
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtInput As TextBox
End Class
