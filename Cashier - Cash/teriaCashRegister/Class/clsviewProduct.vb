Public Class clsviewProduct
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

    Public Property price1() As String
        Get
            Return m_price
        End Get
        Set(ByVal value As String)
            m_price = value
        End Set
    End Property
    Private m_price As String

    Public Property price() As String
        Get
            Return m_pricet
        End Get
        Set(ByVal value As String)
            m_pricet = value
        End Set
    End Property
    Private m_pricet As String
End Class
