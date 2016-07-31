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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonScan = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.TextBoxScanResult = New System.Windows.Forms.TextBox()
        Me.TextBoxWIWE = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonScan, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelStatus, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxScanResult, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxWIWE, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(787, 350)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonScan
        '
        Me.ButtonScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonScan.Location = New System.Drawing.Point(3, 283)
        Me.ButtonScan.Name = "ButtonScan"
        Me.ButtonScan.Size = New System.Drawing.Size(662, 64)
        Me.ButtonScan.TabIndex = 0
        Me.ButtonScan.Text = "START"
        Me.ButtonScan.UseVisualStyleBackColor = True
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelStatus.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(3, 210)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(662, 70)
        Me.LabelStatus.TabIndex = 1
        '
        'TextBoxScanResult
        '
        Me.TextBoxScanResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxScanResult.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxScanResult.Location = New System.Drawing.Point(3, 73)
        Me.TextBoxScanResult.Multiline = True
        Me.TextBoxScanResult.Name = "TextBoxScanResult"
        Me.TextBoxScanResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxScanResult.Size = New System.Drawing.Size(662, 134)
        Me.TextBoxScanResult.TabIndex = 2
        '
        'TextBoxWIWE
        '
        Me.TextBoxWIWE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxWIWE.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxWIWE.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxWIWE.Name = "TextBoxWIWE"
        Me.TextBoxWIWE.Size = New System.Drawing.Size(662, 44)
        Me.TextBoxWIWE.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 350)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonScan As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents TextBoxScanResult As TextBox
    Friend WithEvents TextBoxWIWE As TextBox
End Class
