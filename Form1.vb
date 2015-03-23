Imports MapAround.Mapping
Imports System.Windows.Forms
Imports System
Imports MapAround.Geometry
Imports MapAround.DataProviders
Imports MapInfo.IO


Partial Public Class Form1
    Inherits Form
    Private _map As Map

    Public Enum test
        b1 = 1
        b2 = 2
    End Enum

    Public Function _test() As test
        Return test.b1
    End Function

    Public Sub m()
        If _test() = test.b1 Then

        End If
    End Sub
    Public Sub New()
        'Берем из библиотеки MapAround контрол управления (MapControl) и размещаем его на форме
        InitializeComponent()
        _map = New MapAround.Mapping.Map()
        ' Устанавливаем созданный объект MAP
        With MapControl
            .Map = _map
            '.AnimationTime
            '.Animation = False
            '.MouseWheelZooming = True
            '.ZoomPercent = 10
        End With
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        ' Действия функции «Добавить слой»

        Using dialog = New OpenFileDialog()
            dialog.Filter = "MapInfo TAB files|*.tab|ESRI Shape-file|*.shp"
            dialog.CheckFileExists = True

            If dialog.ShowDialog() = DialogResult.OK Then
                ' Создание нового слоя
                Dim layer = New FeatureLayer() With {.[Alias] = dialog.FileName, .Visible = True}

                Dim shape As SpatialDataProviderBase
                Select Case IO.Path.GetExtension(dialog.FileName).ToLower

                    Case ".tab"
                        shape = New TABFileSpatialDataProvider() With {.FileName = dialog.FileName}
                        shape.QueryFeatures(layer)
                    Case ".shp"
                        shape = New ShapeFileSpatialDataProvider() With {.FileName = dialog.FileName}
                        shape.QueryFeatures(layer)
                End Select

                ' Загрузка данных из Shape файла
                _map.AddLayer(layer)
                ' Добавляем слой к карте
                ' Находим новый ViewBox (требуется для отображения)
                SetViewBox()
                MapControl.Focus()
            End If
        End Using
    End Sub

    Private Sub SetViewBox()
        ' Метод поиска ViewBox
        Dim rectangle As BoundingRectangle = _map.CalculateBoundingRectangle()
        If rectangle.IsEmpty() Then
            Return
        End If
        ' Расчет  области данных карты
        ' Поправка, для того, что бы вписать данные в контрол
        Dim deltaY As Double = rectangle.Width * MapControl.Height / 2 / MapControl.Width - rectangle.Height / 2

        ' Установка нового ViewBox
        MapControl.SetViewBox(New BoundingRectangle(rectangle.MinX, rectangle.MinY - deltaY, rectangle.MaxX, rectangle.MaxY + deltaY))

        'MapControl.DragMode = MapAround.UI.WinForms.MapControl.DraggingMode.Zoom
    End Sub

    '  Добавляем функции приблизить/отдалить объект на карте
    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs)
        If _map.Layers.Count = 0 Then
            Return
        End If
        MapControl.ZoomIn()
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs)
        If _map.Layers.Count = 0 Then
            Return
        End If
        MapControl.ZoomOut()
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        If _map.Layers.Count = 0 Then
            Return
        End If
        SetViewBox()
    End Sub

    Private Sub MapControl_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MapControl.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            If _map.Layers.Count = 0 Then
                Return
            End If
            SetViewBox()
        End If
    End Sub


End Class
