
Class clsUser

    Public Property No() As Integer
        Get
            Return m_Id
        End Get
        Set(ByVal value As Integer)
            m_Id = value
        End Set
    End Property
    Private m_Id As Integer

    Public Property Code() As String
        Get
            Return m_Code1
        End Get
        Set(ByVal value As String)
            m_Code1 = value
        End Set
    End Property
    Private m_Code1 As String

    Public Property Material() As String
        Get
            Return m_Name1
        End Get
        Set(ByVal value As String)
            m_Name1 = value
        End Set
    End Property
    Private m_Name1 As String

   

    Public Property Category() As String
        Get
            Return m_Category1
        End Get
        Set(ByVal value As String)
            m_Category1 = value
        End Set
    End Property
    Private m_Category1 As String

End Class


