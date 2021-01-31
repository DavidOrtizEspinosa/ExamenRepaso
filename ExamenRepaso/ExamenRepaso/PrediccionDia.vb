

Namespace ExamenRepaso

    Public Class PrediccionDia

        Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub


        Private _dia As String
        Public Property Dia() As String
            Get
                Return _dia
            End Get
            Set(ByVal value As String)
                If (value! = _dia) Then{
            _dia = value
                NotifyPropertyChanged("Dia")
            }

        End Set
        End Property

        Private _prediccion As String
        Public Property Prediccion() As String
            Get
                Return _prediccion
            End Get
            Set(ByVal value As String)
                If (value! = _prediccion) Then{
            _prediccion = value
                NotifyPropertyChanged("Prediccion")
            }
        End Set
        End Property

        Private _minimaFarenheit As Integer
        Public Property MinimaFarenheit() As Integer
            Get
                Return _minimaFarenheit
            End Get
            Set(ByVal value As Integer)
                If (value! = _minimaFarenheit) Then{
            _minimaFarenheit = value
                NotifyPropertyChanged("MinimaFarenheit")
            }
        End Set
        End Property

        Private _maximaFarenheit As Integer
        Public Property MaximaFarenheit() As Integer
            Get
                Return _maximaFarenheit
            End Get
            Set(ByVal value As Integer)
                If (value! = _maximaFarenheit) Then{
            _maximaFarenheit = value
                NotifyPropertyChanged("MaximaFarenheit")
            }
        End Set
        End Property

        Public Sub New(dia As String, prediccion As String, minima As Integer, maxima As Integer)
            Me.Dia = dia
            Me.Prediccion = prediccion
            Me.MinimaFarenheit = minima
            Me.MaximaFarenheit = maxima
        End Sub

        Public Shared Function ObtenerDatos() As ObservableCollection(Of PrediccionDia)
            Dim resultado As New ObservableCollection(Of PrediccionDia)

            resultado.Add(New PrediccionDia("Lunes", "sol", 44, 60))
            resultado.Add(New PrediccionDia("Martes", "nubes", 55, 70))
            resultado.Add(New PrediccionDia("Miércoles", "sol", 35, 55))
            resultado.Add(New PrediccionDia("Jueves", "nubes", 48, 65))
            resultado.Add(New PrediccionDia("Viernes", "lluvia", 37, 50))
            resultado.Add(New PrediccionDia("Sábado", "nubes", 30, 50))
            resultado.Add(New PrediccionDia("Domingo", "nieve", 28, 40))

            Return resultado
        End Function

    End Class
