Imports System.Text

''' <summary>
''' 本アプリのメインモジュール
''' </summary>
''' <remarks></remarks>
Module modMain

#Region "Datas"

	Private _windowMain As windowMain = Nothing


	Private _lstMsgBoxBtnInfo As List(Of clsMessageBoxButtonInfo) = Nothing

#End Region

	''' <summary>
	''' メッセージボックス情報を取得
	''' </summary>
	''' <param name="enmMsgBoxButton"></param>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public ReadOnly Property MessageBoxCloneInfo(ByVal enmMsgBoxButton As MessageBoxButtons)
		Get
			Dim targetMsgBoxInfo As clsMessageBoxButtonInfo = Nothing

			For Each MsgBoxInfo As clsMessageBoxButtonInfo In _lstMsgBoxBtnInfo
				If MsgBoxInfo.EnumIndex = enmMsgBoxButton Then
					targetMsgBoxInfo = MsgBoxInfo.Clone
				End If
			Next

			If targetMsgBoxInfo Is Nothing Then targetMsgBoxInfo = New clsMessageBoxButtonInfo

			Return targetMsgBoxInfo
		End Get
	End Property



	''' <summary>
	''' エントリーポイント
	''' </summary>
	''' <remarks></remarks>
	<STAThread> _
	Public Sub Main()

		SetUp()

		_windowMain.ShowDialog()
		_windowMain.Dispose()
	End Sub

	''' <summary>
	''' セットアップ
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetUp()
		MakeMessageBoxInfo()

		If _windowMain Is Nothing Then
			_windowMain = New windowMain
		End If
	End Sub

	''' <summary>
	''' メッセージボックス情報を作成
	''' </summary>
	''' <remarks></remarks>
	Private Sub MakeMessageBoxInfo()
		Dim addMsgBtnInfo As clsMessageBoxButtonInfo = Nothing

		If _lstMsgBoxBtnInfo Is Nothing Then
			_lstMsgBoxBtnInfo = New List(Of clsMessageBoxButtonInfo)
		End If
		_lstMsgBoxBtnInfo.Clear()

		addMsgBtnInfo = New clsMessageBoxButtonInfo
		For enmMsgBoxBtn As Integer = 0 To 10
			If addMsgBtnInfo.MakeMeFromMessageBoxButtons(enmMsgBoxBtn) Then
				_lstMsgBoxBtnInfo.Add(addMsgBtnInfo.Clone)
			Else
				Exit For
			End If
		Next
	End Sub

	''' <summary>
	''' 書式化されたメッセージボックスの種類の文字列リストを取得
	''' </summary>
	''' <param name="codePosition">メッセージボックスの数値の位置(-1：種類の前、0：付けない、1：種類の後ろ)</param>
	''' <param name="separateString">種類との分割文字列</param>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetFormattedStyleList(ByVal codePosition As Integer, ByVal separateString As String) As List(Of String)
		Dim styleItem As List(Of String) = Nothing
		Dim formattedStyleItem As List(Of String) = Nothing
		Dim addString As StringBuilder = Nothing

		addString = New StringBuilder
		addString.Capacity = 32

		styleItem = GetStyleList()

		formattedStyleItem = New List(Of String)
		For Each styleString As String In styleItem
			addString.Clear()

			Select Case codePosition
				Case modDefine.PositionNum.Before
					addString.Append("")

				Case modDefine.PositionNum.After


			End Select


			formattedStyleItem.Add("")
		Next

		Return formattedStyleItem
	End Function

	''' <summary>
	''' メッセージボックスの種類の文字列リストを取得
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function GetStyleList() As List(Of String)
		Dim styleItem As List(Of String) = Nothing
		styleItem = New List(Of String)

		For buttonsIndex As Integer = 0 To MessageBoxButtons.RetryCancel

		Next

		Return styleItem
	End Function

	''' <summary>
	''' メッセージボックスの種類をコンボボックスに追加
	''' </summary>
	''' <param name="cbxTarget"></param>
	''' <remarks></remarks>
	Public Sub AddMsgBoxTypeToComboBox(ByRef cbxTarget As ComboBox)
		With cbxTarget
			For Each addMsgBoxInfo As clsMessageBoxButtonInfo In _lstMsgBoxBtnInfo
				.Items.Add(addMsgBoxInfo.ButtonsText)
			Next
		End With
	End Sub

End Module
