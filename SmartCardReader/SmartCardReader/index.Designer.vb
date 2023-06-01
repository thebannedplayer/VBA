<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.btnOpenFormSmartcard = New System.Windows.Forms.Button()
        Me.btnOpenFormcusSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenFormSmartcard
        '
        Me.btnOpenFormSmartcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFormSmartcard.Location = New System.Drawing.Point(81, 300)
        Me.btnOpenFormSmartcard.Name = "btnOpenFormSmartcard"
        Me.btnOpenFormSmartcard.Size = New System.Drawing.Size(220, 60)
        Me.btnOpenFormSmartcard.TabIndex = 0
        Me.btnOpenFormSmartcard.Text = "เปิดหน้าเพิ่มผู้ป่วย"
        Me.btnOpenFormSmartcard.UseVisualStyleBackColor = True
        '
        'btnOpenFormcusSearch
        '
        Me.btnOpenFormcusSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFormcusSearch.Location = New System.Drawing.Point(500, 300)
        Me.btnOpenFormcusSearch.Name = "btnOpenFormcusSearch"
        Me.btnOpenFormcusSearch.Size = New System.Drawing.Size(220, 60)
        Me.btnOpenFormcusSearch.TabIndex = 1
        Me.btnOpenFormcusSearch.Text = "เปิดหน้าค้นหาผู้ป่วย"
        Me.btnOpenFormcusSearch.UseVisualStyleBackColor = True
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOpenFormcusSearch)
        Me.Controls.Add(Me.btnOpenFormSmartcard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "index"
        Me.Text = "เลือกฟังก์ชัน"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenFormSmartcard As Button
    Friend WithEvents btnOpenFormcusSearch As Button
End Class
