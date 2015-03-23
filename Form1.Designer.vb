<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.MapControl = New MapAround.UI.WinForms.MapControl()
        CType(Me.MapControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(258, 11)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(75, 23)
        Me.btnViewAll.TabIndex = 4
        Me.btnViewAll.Text = "ViewAll"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'MapControl
        '
        Me.MapControl.AlignmentWhileZooming = True
        Me.MapControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MapControl.Animation = True
        Me.MapControl.AnimationTime = 400
        Me.MapControl.DragMode = MapAround.UI.WinForms.MapControl.DraggingMode.Pan
        Me.MapControl.DragThreshold = 1
        Me.MapControl.Editor = Nothing
        Me.MapControl.IsDragging = False
        Me.MapControl.Location = New System.Drawing.Point(12, 39)
        Me.MapControl.Map = Nothing
        Me.MapControl.MouseWheelZooming = True
        Me.MapControl.Name = "MapControl"
        Me.MapControl.SelectionMargin = 3
        Me.MapControl.SelectionRectangleColor = System.Drawing.SystemColors.Highlight
        Me.MapControl.Size = New System.Drawing.Size(912, 396)
        Me.MapControl.TabIndex = 0
        Me.MapControl.Text = "MapControl"
        Me.MapControl.ZoomPercent = 60
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 447)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.MapControl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MapControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MapControl As MapAround.UI.WinForms.MapControl
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnViewAll As System.Windows.Forms.Button

End Class
