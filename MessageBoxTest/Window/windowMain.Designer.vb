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
		Me.rbtDefButton1 = New System.Windows.Forms.RadioButton()
		Me.lblType = New System.Windows.Forms.Label()
		Me.cbxType = New System.Windows.Forms.ComboBox()
		Me.gbxBody = New System.Windows.Forms.GroupBox()
		Me.btnCopyBodyToCB = New System.Windows.Forms.Button()
		Me.btnBodyClear = New System.Windows.Forms.Button()
		Me.txtBody = New System.Windows.Forms.TextBox()
		Me.btnShow = New System.Windows.Forms.Button()
		Me.gbxStyle = New System.Windows.Forms.GroupBox()
		Me.rbtNewStyle = New System.Windows.Forms.RadioButton()
		Me.rbtOldStyle = New System.Windows.Forms.RadioButton()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.txtTitle = New System.Windows.Forms.TextBox()
		Me.lblIcon = New System.Windows.Forms.Label()
		Me.cbxIcon = New System.Windows.Forms.ComboBox()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.gbxDefButton.SuspendLayout()
		Me.gbxBody.SuspendLayout()
		Me.gbxStyle.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'gbxDefButton
		'
		Me.gbxDefButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbxDefButton.Controls.Add(Me.rbtDefButton3)
		Me.gbxDefButton.Controls.Add(Me.rbtDefButton2)
		Me.gbxDefButton.Controls.Add(Me.rbtDefButton1)
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
		'rbtDefButton1
		'
		Me.rbtDefButton1.AutoSize = True
		Me.rbtDefButton1.Location = New System.Drawing.Point(12, 26)
		Me.rbtDefButton1.Name = "rbtDefButton1"
		Me.rbtDefButton1.Size = New System.Drawing.Size(74, 24)
		Me.rbtDefButton1.TabIndex = 0
		Me.rbtDefButton1.TabStop = True
		Me.rbtDefButton1.Text = "ボタン1"
		Me.rbtDefButton1.UseVisualStyleBackColor = True
		'
		'lblType
		'
		Me.lblType.AutoSize = True
		Me.lblType.Location = New System.Drawing.Point(5, 15)
		Me.lblType.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lblType.Name = "lblType"
		Me.lblType.Size = New System.Drawing.Size(35, 20)
		Me.lblType.TabIndex = 1
		Me.lblType.Text = "種類"
		'
		'cbxType
		'
		Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxType.FormattingEnabled = True
		Me.cbxType.Location = New System.Drawing.Point(46, 12)
		Me.cbxType.Name = "cbxType"
		Me.cbxType.Size = New System.Drawing.Size(195, 28)
		Me.cbxType.TabIndex = 2
		'
		'gbxBody
		'
		Me.gbxBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.gbxBody.Controls.Add(Me.btnCopyBodyToCB)
		Me.gbxBody.Controls.Add(Me.btnBodyClear)
		Me.gbxBody.Controls.Add(Me.txtBody)
		Me.gbxBody.Location = New System.Drawing.Point(1, 145)
		Me.gbxBody.Name = "gbxBody"
		Me.gbxBody.Size = New System.Drawing.Size(442, 230)
		Me.gbxBody.TabIndex = 3
		Me.gbxBody.TabStop = False
		Me.gbxBody.Text = "メッセージ内容"
		'
		'btnCopyBodyToCB
		'
		Me.btnCopyBodyToCB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCopyBodyToCB.Location = New System.Drawing.Point(356, 18)
		Me.btnCopyBodyToCB.Name = "btnCopyBodyToCB"
		Me.btnCopyBodyToCB.Size = New System.Drawing.Size(75, 23)
		Me.btnCopyBodyToCB.TabIndex = 2
		Me.btnCopyBodyToCB.Text = "コピー"
		Me.btnCopyBodyToCB.UseVisualStyleBackColor = True
		'
		'btnBodyClear
		'
		Me.btnBodyClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnBodyClear.Location = New System.Drawing.Point(252, 18)
		Me.btnBodyClear.Name = "btnBodyClear"
		Me.btnBodyClear.Size = New System.Drawing.Size(75, 23)
		Me.btnBodyClear.TabIndex = 1
		Me.btnBodyClear.Text = "クリア"
		Me.btnBodyClear.UseVisualStyleBackColor = True
		'
		'txtBody
		'
		Me.txtBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtBody.Location = New System.Drawing.Point(1, 45)
		Me.txtBody.Margin = New System.Windows.Forms.Padding(1)
		Me.txtBody.Multiline = True
		Me.txtBody.Name = "txtBody"
		Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtBody.Size = New System.Drawing.Size(438, 181)
		Me.txtBody.TabIndex = 0
		'
		'btnShow
		'
		Me.btnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnShow.Location = New System.Drawing.Point(340, 389)
		Me.btnShow.Name = "btnShow"
		Me.btnShow.Size = New System.Drawing.Size(92, 27)
		Me.btnShow.TabIndex = 4
		Me.btnShow.Text = "表示(&S)"
		Me.btnShow.UseVisualStyleBackColor = True
		'
		'gbxStyle
		'
		Me.gbxStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.gbxStyle.Controls.Add(Me.rbtNewStyle)
		Me.gbxStyle.Controls.Add(Me.rbtOldStyle)
		Me.gbxStyle.Location = New System.Drawing.Point(1, 378)
		Me.gbxStyle.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.gbxStyle.Name = "gbxStyle"
		Me.gbxStyle.Size = New System.Drawing.Size(208, 48)
		Me.gbxStyle.TabIndex = 5
		Me.gbxStyle.TabStop = False
		Me.gbxStyle.Text = "スタイル"
		'
		'rbtNewStyle
		'
		Me.rbtNewStyle.AutoSize = True
		Me.rbtNewStyle.Location = New System.Drawing.Point(109, 17)
		Me.rbtNewStyle.Name = "rbtNewStyle"
		Me.rbtNewStyle.Size = New System.Drawing.Size(93, 24)
		Me.rbtNewStyle.TabIndex = 1
		Me.rbtNewStyle.TabStop = True
		Me.rbtNewStyle.Text = "新版(.Net)"
		Me.rbtNewStyle.UseVisualStyleBackColor = True
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
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Location = New System.Drawing.Point(5, 115)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(61, 20)
		Me.lblTitle.TabIndex = 6
		Me.lblTitle.Text = "タイトル"
		'
		'txtTitle
		'
		Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtTitle.Location = New System.Drawing.Point(70, 112)
		Me.txtTitle.Name = "txtTitle"
		Me.txtTitle.Size = New System.Drawing.Size(362, 27)
		Me.txtTitle.TabIndex = 7
		'
		'lblIcon
		'
		Me.lblIcon.AutoSize = True
		Me.lblIcon.Location = New System.Drawing.Point(244, 15)
		Me.lblIcon.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
		Me.lblIcon.Name = "lblIcon"
		Me.lblIcon.Size = New System.Drawing.Size(61, 20)
		Me.lblIcon.TabIndex = 8
		Me.lblIcon.Text = "アイコン"
		'
		'cbxIcon
		'
		Me.cbxIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxIcon.FormattingEnabled = True
		Me.cbxIcon.Location = New System.Drawing.Point(311, 12)
		Me.cbxIcon.Name = "cbxIcon"
		Me.cbxIcon.Size = New System.Drawing.Size(80, 28)
		Me.cbxIcon.TabIndex = 9
		'
		'picIcon
		'
		Me.picIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.picIcon.Location = New System.Drawing.Point(400, 8)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(36, 36)
		Me.picIcon.TabIndex = 10
		Me.picIcon.TabStop = False
		'
		'windowMain
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(444, 428)
		Me.Controls.Add(Me.picIcon)
		Me.Controls.Add(Me.cbxIcon)
		Me.Controls.Add(Me.lblIcon)
		Me.Controls.Add(Me.txtTitle)
		Me.Controls.Add(Me.lblTitle)
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
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents gbxDefButton As System.Windows.Forms.GroupBox
	Friend WithEvents rbtDefButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents rbtDefButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents rbtDefButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents lblType As System.Windows.Forms.Label
	Friend WithEvents cbxType As System.Windows.Forms.ComboBox
	Friend WithEvents gbxBody As System.Windows.Forms.GroupBox
	Friend WithEvents txtBody As System.Windows.Forms.TextBox
	Friend WithEvents btnShow As System.Windows.Forms.Button
	Friend WithEvents gbxStyle As System.Windows.Forms.GroupBox
	Friend WithEvents rbtNewStyle As System.Windows.Forms.RadioButton
	Friend WithEvents rbtOldStyle As System.Windows.Forms.RadioButton
	Friend WithEvents btnBodyClear As System.Windows.Forms.Button
	Friend WithEvents btnCopyBodyToCB As System.Windows.Forms.Button
	Friend WithEvents lblTitle As System.Windows.Forms.Label
	Friend WithEvents txtTitle As System.Windows.Forms.TextBox
	Friend WithEvents lblIcon As System.Windows.Forms.Label
	Friend WithEvents cbxIcon As System.Windows.Forms.ComboBox
	Friend WithEvents picIcon As System.Windows.Forms.PictureBox

End Class
