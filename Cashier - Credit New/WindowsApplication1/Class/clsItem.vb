Public Class clsItem
    Public Property itemcode() As String
        Get
            Return m_code
        End Get
        Set(ByVal value As String)
            m_code = value
        End Set
    End Property
    Private m_code As String

    Public Property itemname() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            m_name = value
        End Set
    End Property
    Private m_name As String

    Public Property unit() As String
        Get
            Return m_unit
        End Get
        Set(ByVal value As String)
            m_unit = value
        End Set
    End Property
    Private m_unit As String

    Public Property discount() As String
        Get
            Return m_discount
        End Get
        Set(ByVal value As String)
            m_discount = value
        End Set
    End Property
    Private m_discount As String

    Public Property unitprice() As String
        Get
            Return m_unitprice
        End Get
        Set(ByVal value As String)
            m_unitprice = value
        End Set
    End Property
    Private m_unitprice As String
End Class
