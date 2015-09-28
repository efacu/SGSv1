<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Panel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel))
        Me.PictureBoxProveedores = New System.Windows.Forms.PictureBox()
        Me.PictureBoxIngresos = New System.Windows.Forms.PictureBox()
        Me.PictureBoxEgresos = New System.Windows.Forms.PictureBox()
        Me.PictureBoxProductos = New System.Windows.Forms.PictureBox()
        Me.PictureBoxParam = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxParam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxProveedores
        '
        resources.ApplyResources(Me.PictureBoxProveedores, "PictureBoxProveedores")
        Me.PictureBoxProveedores.Name = "PictureBoxProveedores"
        Me.PictureBoxProveedores.TabStop = False
        '
        'PictureBoxIngresos
        '
        resources.ApplyResources(Me.PictureBoxIngresos, "PictureBoxIngresos")
        Me.PictureBoxIngresos.Name = "PictureBoxIngresos"
        Me.PictureBoxIngresos.TabStop = False
        '
        'PictureBoxEgresos
        '
        resources.ApplyResources(Me.PictureBoxEgresos, "PictureBoxEgresos")
        Me.PictureBoxEgresos.Name = "PictureBoxEgresos"
        Me.PictureBoxEgresos.TabStop = False
        '
        'PictureBoxProductos
        '
        resources.ApplyResources(Me.PictureBoxProductos, "PictureBoxProductos")
        Me.PictureBoxProductos.Name = "PictureBoxProductos"
        Me.PictureBoxProductos.TabStop = False
        '
        'PictureBoxParam
        '
        resources.ApplyResources(Me.PictureBoxParam, "PictureBoxParam")
        Me.PictureBoxParam.Name = "PictureBoxParam"
        Me.PictureBoxParam.TabStop = False
        '
        'Panel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBoxParam)
        Me.Controls.Add(Me.PictureBoxProductos)
        Me.Controls.Add(Me.PictureBoxEgresos)
        Me.Controls.Add(Me.PictureBoxIngresos)
        Me.Controls.Add(Me.PictureBoxProveedores)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "Panel"
        CType(Me.PictureBoxProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxParam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxProveedores As PictureBox
    Friend WithEvents PictureBoxIngresos As PictureBox
    Friend WithEvents PictureBoxEgresos As PictureBox
    Friend WithEvents PictureBoxProductos As PictureBox
    Friend WithEvents PictureBoxParam As PictureBox
End Class
