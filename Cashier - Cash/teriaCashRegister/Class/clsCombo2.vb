Public Class clsCombo2
    Public Property code() As String
        Get
            Return m_code
        End Get
        Set(ByVal value As String)
            m_code = value
        End Set
    End Property
    Private m_code As String

    Public Property name() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            m_name = value
        End Set
    End Property
    Private m_name As String
End Class
