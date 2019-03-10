''' <summary>
''' メインウィンドウ
''' </summary>
''' <remarks></remarks>
Public Class windowMain

#Region "Property"



#End Region

#Region "Event"

	''' <summary>
	''' 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub windowMain_Load(sender As Object, e As EventArgs) Handles Me.Load
		Preparation()

	End Sub

	''' <summary>
	''' 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
		If sender.Equals(Me.btnShow) Then
			Dim targetMsgBoxInfo As clsMessageBoxButtonInfo

			targetMsgBoxInfo = GetSelectedMsgBox()
			SetDataFromWindow(targetMsgBoxInfo)

			targetMsgBoxInfo.ShowMessageBox(Me.txtTitle.Text.Trim, Me.txtBody.Text.Trim, GetIconNumber)
		End If
	End Sub

	''' <summary>
	''' 
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub comboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged, cbxIcon.SelectedIndexChanged
		'Debug.Print("種類コンボボックス選択インデックス変更イベント：" & Me.cbxType.SelectedIndex.ToString & Me.cbxType.SelectedText)
		If sender.Equals(Me.cbxType) Then
			UpdateCtrlStateBasedMsgBoxType()

		ElseIf sender.Equals(Me.cbxIcon) Then
			UpdateIconPicBasedCbxIcon()

		End If
	End Sub


#End Region

#Region "Function"

	''' <summary>
	''' 前準備
	''' </summary>
	''' <remarks></remarks>
	Private Sub Preparation()
		InitWindow()
		SetMsgBoxTypeCombo()
		SetIconCombo()
	End Sub

	''' <summary>
	''' 種類コンボボックスにメッセージボックスを入れ込む
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetMsgBoxTypeCombo()
		Me.cbxType.Items.Clear()

		Me.cbxType.BeginUpdate()
		modMain.AddMsgBoxTypeToComboBox(Me.cbxType)
		Me.cbxType.SelectedIndex = 0
		Me.cbxType.EndUpdate()
	End Sub

	''' <summary>
	''' アイコンコンボボックスをセット
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetIconCombo()
		With Me.cbxIcon
			.BeginUpdate()

			.Items.Add("なし" & Space(50) & "0")
			'.Items.Add("アスタリスク" & Space(50) & "")
			.Items.Add("エラー" & Space(50) & "16")
			.Items.Add("質問" & Space(50) & "32")
			.Items.Add("感嘆" & Space(50) & "48")
			.Items.Add("情報" & Space(50) & "64")
			'.Items.Add(SystemIcons.Asterisk.ToBitmap)
			'.Items.Add(SystemIcons.Error.ToBitmap)
			'.Items.Add(SystemIcons.Question.ToBitmap)
			'.Items.Add(SystemIcons.Exclamation.ToBitmap)
			'.Items.Add(SystemIcons.Information.ToBitmap)

			.SelectedIndex = 0

			.EndUpdate()
		End With
	End Sub

	''' <summary>
	''' ウィンドウを初期化
	''' </summary>
	''' <remarks></remarks>
	Private Sub InitWindow()
		UpdateRbtDefBtnVisible(0)
	End Sub

	''' <summary>
	''' 現在選択されているメッセージボックスを取得
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function GetSelectedMsgBox() As clsMessageBoxButtonInfo
		Return modMain.MessageBoxCloneInfo(Me.cbxType.SelectedIndex)
	End Function

	''' <summary>
	''' 画面の情報をデータに反映
	''' </summary>
	''' <param name="MsgBoxInfo"></param>
	''' <remarks></remarks>
	Private Sub SetDataFromWindow(ByRef MsgBoxInfo As clsMessageBoxButtonInfo)
		MsgBoxInfo.DefaultButton = GetDefaultButton()
	End Sub

	''' <summary>
	''' 選択されているアイコン番号を取得
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function GetIconNumber() As MessageBoxIcon
		'Dim hideNum As Integer = 0

		Return CInt(Strings.Right(Me.cbxIcon.Text, 2).TrimStart)
	End Function

	''' <summary>
	''' デフォルトボタンを取得
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function GetDefaultButton() As MessageBoxDefaultButton
		If Me.rbtDefButton1.Checked Then
			Return MessageBoxDefaultButton.Button1
		ElseIf Me.rbtDefButton2.Checked Then
			Return MessageBoxDefaultButton.Button2
		ElseIf Me.rbtDefButton3.Checked Then
			Return MessageBoxDefaultButton.Button3
		Else
			Return MessageBoxDefaultButton.Button1
		End If
	End Function

	''' <summary>
	''' 選択されたコンボボックスの種類によってコントロールの状態を更新
	''' </summary>
	''' <remarks></remarks>
	Private Sub UpdateCtrlStateBasedMsgBoxType()
		Dim selecedMsgBox As clsMessageBoxButtonInfo = Nothing

		selecedMsgBox = GetSelectedMsgBox()
		UpdateRbtDefBtnVisible(selecedMsgBox.Buttons)
		SetRbtDefault(selecedMsgBox.DefaultButton)

		Select Case selecedMsgBox.EnumIndex
			Case MessageBoxButtons.OK
				Me.rbtDefButton1.Text = "OK"
				Me.rbtDefButton1.Enabled = False

			Case MessageBoxButtons.OKCancel
				Me.rbtDefButton1.Text = "OK"
				Me.rbtDefButton2.Text = "キャンセル"

			Case MessageBoxButtons.AbortRetryIgnore
				Me.rbtDefButton1.Text = "中止"
				Me.rbtDefButton2.Text = "再試行"
				Me.rbtDefButton3.Text = "無視"

			Case MessageBoxButtons.YesNoCancel
				Me.rbtDefButton1.Text = "はい"
				Me.rbtDefButton2.Text = "いいえ"
				Me.rbtDefButton3.Text = "キャンセル"

			Case MessageBoxButtons.YesNo
				Me.rbtDefButton1.Text = "はい"
				Me.rbtDefButton2.Text = "いいえ"

			Case MessageBoxButtons.RetryCancel
				Me.rbtDefButton1.Text = "再試行"
				Me.rbtDefButton2.Text = "キャンセル"

		End Select
	End Sub

	''' <summary>
	''' アイコンコンボで選択しているアイコンをピクチャに反映
	''' </summary>
	''' <remarks></remarks>
	Private Sub UpdateIconPicBasedCbxIcon()
		'Dim canvas As New Bitmap(Me.picIcon.Width, Me.picIcon.Height)
		'Dim grphx As Graphics = Graphics.FromImage(canvas)

		Select Case GetIconNumber()
			Case MessageBoxIcon.None
				Me.picIcon.Image = Nothing
				'grphx.DrawIcon(Nothing, 0, 0)

			Case MessageBoxIcon.Error
				Me.picIcon.Image = SystemIcons.Error.ToBitmap
				'grphx.DrawIcon(SystemIcons.Error, 0, 0)

			Case MessageBoxIcon.Question
				Me.picIcon.Image = SystemIcons.Question.ToBitmap
				'grphx.DrawIcon(SystemIcons.Question, 0, 0)

			Case MessageBoxIcon.Exclamation
				Me.picIcon.Image = SystemIcons.Exclamation.ToBitmap
				'grphx.DrawIcon(SystemIcons.Exclamation, 0, 0)

			Case MessageBoxIcon.Information
				Me.picIcon.Image = SystemIcons.Information.ToBitmap
				'grphx.DrawIcon(SystemIcons.Information, 0, 0)

		End Select

		'Me.picIcon.Image = canvas
	End Sub

	''' <summary>
	''' 指定した数値によってデフォルトボタンの表示を更新
	''' </summary>
	''' <param name="ButtonNum"></param>
	''' <remarks></remarks>
	Private Sub UpdateRbtDefBtnVisible(ByVal ButtonNum As Integer)
		Me.rbtDefButton1.Visible = False
		Me.rbtDefButton1.Enabled = False
		Me.rbtDefButton1.Text = String.Empty
		Me.rbtDefButton2.Visible = False
		Me.rbtDefButton2.Enabled = False
		Me.rbtDefButton2.Text = String.Empty
		Me.rbtDefButton3.Visible = False
		Me.rbtDefButton3.Enabled = False
		Me.rbtDefButton3.Text = String.Empty

		If ButtonNum.Equals(0) OrElse ButtonNum.CompareTo(3).Equals(1) Then Return

		Me.rbtDefButton1.Visible = True
		Me.rbtDefButton1.Enabled = True

		If ButtonNum.Equals(1) Then Return

		Me.rbtDefButton2.Visible = True
		Me.rbtDefButton2.Enabled = True

		If ButtonNum.Equals(2) Then Return

		Me.rbtDefButton3.Visible = True
		Me.rbtDefButton3.Enabled = True
	End Sub

	''' <summary>
	''' 指定したデフォルトボタンに値するラジオボタンに反映
	''' </summary>
	''' <param name="MsgBoxDefBtn"></param>
	''' <remarks></remarks>
	Private Sub SetRbtDefault(ByVal MsgBoxDefBtn As MessageBoxDefaultButton)
		Select Case MsgBoxDefBtn
			Case MessageBoxDefaultButton.Button1
				Me.rbtDefButton1.Checked = True

			Case MessageBoxDefaultButton.Button2
				Me.rbtDefButton2.Checked = True

			Case MessageBoxDefaultButton.Button3
				Me.rbtDefButton3.Checked = True

		End Select
	End Sub


#End Region

End Class
