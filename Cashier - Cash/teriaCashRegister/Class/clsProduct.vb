Public Class clsProduct
    Public Property prodcode() As String
        Get
            Return m_prodcode
        End Get
        Set(ByVal value As String)
            m_prodcode = value
        End Set
    End Property
    Private m_prodcode As String

    Public Property prodname() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            m_name = value
        End Set
    End Property
    Private m_name As String
End Class
