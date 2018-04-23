Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl1.Appearance.Options.UseFont = True
			Me.labelControl1.Location = New System.Drawing.Point(156, 106)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(276, 109)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Hello !"
			' 
			' Form1
			' 
			Me.ClientSize = New System.Drawing.Size(607, 326)
			Me.Controls.Add(Me.labelControl1)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
'			Me.Load += New System.EventHandler(Me.Form1_Load_1);
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace

