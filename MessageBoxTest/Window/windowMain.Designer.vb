<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class windowMain
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.gbxDefButton = New System.Windows.Forms.GroupBox()
		Me.rbtDefButton3 = New System.Windows.Forms.RadioButton()
		Me.rbtDefButton2 = New System.Windows.Forms.RadioButton()
		Me.rbtDefButtonOne = New System.Windows.Forms.RadioButton()
		Me.lblType = New System.Windows.Forms.Label()
		Me.cbxType = New System.Windows.Forms.ComboBox()
		Me.gbxBody = New System.Windows.Forms.GroupBox()
		Me.txtBody = New System.Windows.Forms.TextBox()
		Me.btnShow = New System.Windows.Forms.Button()
		Me.gbxStyle = New System.Windows.Forms.GroupBox()
		Me.rbtOldStyle = New System.Windows.Forms.RadioButton()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.gbxDefButton.SuspendLayout()
		Me.gbxBody.SuspendLayout()
		Me.gbxStyle.SuspendLayout()
		Me.SuspendLayout()
		'
		'gbxDefButton
		'
		Me.gbxDefButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbxDefButton.Controls.Add(Me.rbtDefButton3)
		Me.gbxDefButton.Controls.Add(Me.rbtDefButton2)
		Me.gbxDefButton.Controls.Add(Me.rbtDefButtonOne)
		Me.gbxDefButton.Location = New System.Drawing.Point(1, 46)
		Me.gbxDefButton.Name = "gbxDefButton"
		Me.gbxDefButton.Size = New System.Drawing.Size(442, 60)
		Me.gbxDefButton.TabIndex = 0
		Me.gbxDefButton.TabStop = False
		Me.gbxDefButton.Text = "デフォルトボタン"
		'
		'rbtDefButton3
		'
		Me.rbtDefButton3.AutoSize = True
		Me.rbtDefButton3.Location = New System.Drawing.Point(344, 26)
		Me.rbtDefButton3.Name = "rbtDefButton3"
		Me.rbtDefButton3.Size = New System.Drawing.Size(74, 24)
		Me.rbtDefButton3.TabIndex = 2
		Me.rbtDefButton3.TabStop = True
		Me.rbtDefButton3.Text = "ボタン3"
		Me.rbtDefButton3.UseVisualStyleBackColor = True
		'
		'rbtDefButton2
		'
		Me.rbtDefButton2.AutoSize = True
		Me.rbtDefButton2.Location = New System.Drawing.Point(182, 26)
		Me.rbtDefButton2.Name = "rbtDefButton2"
		Me.rbtDefButton2.Size = New System.Drawing.Size(74, 24)
		Me.rbtDefButton2.TabIndex = 1
		Me.rbtDefButton2.TabStop = True
		Me.rbtDefButton2.Text = "ボタン2"
		Me.rbtDefButton2.UseVisualStyleBackColor = True
		'
		'rbtDefButtonOne
		'
		Me.rbtDefButtonOne.AutoSize = True
		Me.rbtDefButtonOne.Location = New System.Drawing.Point(12, 26)
		Me.rbtDefButtonOne.Name = "rbtDefButtonOne"
		Me.rbtDefButtonOne.Size = New System.Drawing.Size(74, 24)
		Me.rbtDefButtonOne.TabIndex = 0
		Me.rbtDefButtonOne.TabStop = True
		Me.rbtDefButtonOne.Text = "ボタン1"
		Me.rbtDefButtonOne.UseVisualStyleBackColor = True
		'
		'lblType
		'
		Me.lblType.AutoSize = True
		Me.lblType.Location = New System.Drawing.Point(9, 15)
		Me.lblType.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lblType.Name = "lblType"
		Me.lblType.Size = New System.Drawing.Size(165, 20)
		Me.lblType.TabIndex = 1
		Me.lblType.Text = "メッセージボックスの種類"
		'
		'cbxType
		'
		Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxType.FormattingEnabled = True
		Me.cbxType.Location = New System.Drawing.Point(180, 12)
		Me.cbxType.Name = "cbxType"
		Me.cbxType.Size = New System.Drawing.Size(179, 28)
		Me.cbxType.TabIndex = 2
		'
		'gbxBody
		'
		Me.gbxBody.Controls.Add(Me.txtBody)
		Me.gbxBody.Location = New System.Drawing.Point(1, 112)
		Me.gbxBody.Name = "gbxBody"
		Me.gbxBody.Size = New System.Drawing.Size(442, 154)
		Me.gbxBody.TabIndex = 3
		Me.gbxBody.TabStop = False
		Me.gbxBody.Text = "メッセージ内容"
		'
		'txtBody
		'
		Me.txtBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtBody.Location = New System.Drawing.Point(1, 24)
		Me.txtBody.Margin = New System.Windows.Forms.Padding(1)
		Me.txtBody.Multiline = True
		Me.txtBody.Name = "txtBody"
		Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtBody.Size = New System.Drawing.Size(438, 126)
		Me.txtBody.TabIndex = 0
		'
		'btnShow
		'
		Me.btnShow.Location = New System.Drawing.Point(340, 279)
		Me.btnShow.Name = "btnShow"
		Me.btnShow.Size = New System.Drawing.Size(92, 27)
		Me.btnShow.TabIndex = 4
		Me.btnShow.Text = "表示(&S)"
		Me.btnShow.UseVisualStyleBackColor = True
		'
		'gbxStyle
		'
		Me.gbxStyle.Controls.Add(Me.RadioButton1)
		Me.gbxStyle.Controls.Add(Me.rbtOldStyle)
		Me.gbxStyle.Location = New System.Drawing.Point(1, 268)
		Me.gbxStyle.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.gbxStyle.Name = "gbxStyle"
		Me.gbxStyle.Size = New System.Drawing.Size(208, 48)
		Me.gbxStyle.TabIndex = 5
		Me.gbxStyle.TabStop = False
		Me.gbxStyle.Text = "スタイル"
		'
		'rbtOldStyle
		'
		Me.rbtOldStyle.AutoSize = True
		Me.rbtOldStyle.Location = New System.Drawing.Point(12, 17)
		Me.rbtOldStyle.Name = "rbtOldStyle"
		Me.rbtOldStyle.Size = New System.Drawing.Size(91, 24)
		Me.rbtOldStyle.TabIndex = 0
		Me.rbtOldStyle.TabStop = True
		Me.rbtOldStyle.Text = "旧版(VB6)"
		Me.rbtOldStyle.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Location = New System.Drawing.Point(109, 17)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(93, 24)
		Me.RadioButton1.TabIndex = 1
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "新版(.Net)"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'windowMain
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(444, 318)
		Me.Controls.Add(Me.gbxStyle)
		Me.Controls.Add(Me.btnShow)
		Me.Controls.Add(Me.gbxBody)
		Me.Controls.Add(Me.cbxType)
		Me.Controls.Add(Me.lblType)
		Me.Controls.Add(Me.gbxDefButton)
		Me.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "windowMain"
		Me.Text = "メッセージボックス作成くん"
		Me.gbxDefButton.ResumeLayout(False)
		Me.gbxDefButton.PerformLayout()
		Me.gbxBody.ResumeLayout(False)
		Me.gbxBody.PerformLayout()
		Me.gbxStyle.ResumeLayout(False)
		Me.gbxStyle.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents gbxDefButton As System.Windows.Forms.GroupBox
	Friend WithEvents rbtDefButtonOne As System.Windows.Forms.RadioButton
	Friend WithEvents rbtDefButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents rbtDefButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents lblType As System.Windows.Forms.Label
	Friend WithEvents cbxType As System.Windows.Forms.ComboBox
	Friend WithEvents gbxBody As System.Windows.Forms.GroupBox
	Friend WithEvents txtBody As System.Windows.Forms.TextBox
	Friend WithEvents btnShow As System.Windows.Forms.Button
	Friend WithEvents gbxStyle As System.Windows.Forms.GroupBox
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents rbtOldStyle As System.Windows.Forms.RadioButton

End Class
