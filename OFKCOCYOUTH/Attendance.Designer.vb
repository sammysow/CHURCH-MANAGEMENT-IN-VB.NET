<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance))
        Me.lblMemID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.cGender = New System.Windows.Forms.ComboBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtSeat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.Txtmale = New System.Windows.Forms.TextBox()
        Me.Txtfemale = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblmale = New System.Windows.Forms.Label()
        Me.lblfemale = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMemID
        '
        Me.lblMemID.Location = New System.Drawing.Point(127, 73)
        Me.lblMemID.Name = "lblMemID"
        Me.lblMemID.Size = New System.Drawing.Size(121, 20)
        Me.lblMemID.TabIndex = 150
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 19)
        Me.Label17.TabIndex = 149
        Me.Label17.Text = "User ID"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(352, 349)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 148
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'cGender
        '
        Me.cGender.FormattingEnabled = True
        Me.cGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cGender.Location = New System.Drawing.Point(126, 164)
        Me.cGender.Name = "cGender"
        Me.cGender.Size = New System.Drawing.Size(121, 21)
        Me.cGender.TabIndex = 147
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(383, 165)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(121, 20)
        Me.txtphone.TabIndex = 146
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 120)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(377, 20)
        Me.txtName.TabIndex = 145
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 19)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Phone Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Full Name"
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoCompleteCustomSource.AddRange(New String() {"MARY ESSIEN", "KWADWO KYEI MENSAH", "JUSTINA GYASI", "ADOMAKO MENSAH", "VERONICA MENSAH", "AFIA DUFIE", "GRACE OWUSU ANANE", "ISAAC SONFUL COFFIE", "OLIVIA GYIMAH", "GEORGINA MBIL", "GLORIA  MENSAH", "DORIS AMANKWAAH", "HACKMAN KOFI DADZIE", "DIAN OFORI ASANTE", "DANIEL OWUSU", "COMFORT AKWELEY OKAI", "FAUSTINA AFRIYIE MENSAH", "MICHAEL OFORI", "OHEMAA BRENYA AMOFAH", "PATRICIA  CUDJOE", "AMANKWAA BAFFOUR", "RICHARD ASARE", "ERIC AKWASI JUNIOR AGYEMANG", "RICHARD  AGYEI", "JACOB OKYERE", "VIVIAN SARFOWAA APPIAH", "CECILIA  AMANKWAA BAFFOUR", "BEATRICE OWUSU SARPONG", "ABA ADAZOA", "SAMUEL  EGYIR", "JANET EGYIR", "NANA ARABA ABOKOMA EGYIR", "MARY FRIMPONG", "ROSEMARY KYEI", "YAW BAFFOE-KRAPIM", "RALPHAEL  QUAINOO", "FELICIA ADJEI", "MERCY  APPIAH", "BISMARK OPPONG", "MAVIS ASARE", "NAOMI BRAGO MANU", "DORCAS AMOAH", "GEORGE FETUAH", "JULIANA OSEI", "RITA OWUSU", "JOYCE APPIAH DADZIE", "ADWOA SERWAA SEREBOUR", "KOFI OWUSU - AFRIYIE", "EVANS TIEKU", "RANSFORD KWEKU BILSON", "MAVIS ANIMA", "JOHN KWABENA MBIL", "SELINA AFRIYIE", " AFIA DANKWAA ADU - PAKO", "CHARITY NYARKO", "BARBARA APPIAH", "REBECCA  AGYEIWAA", "ALFRED EGHAN", "AKWASI KYEI AFOAKWAH", "RASHIDA ADAMA", "FREDERICK AMEDONU", "BISMARK AMEDONU", "JOSEPH BENJAMIN DANQUAH", "ERNESTINA FRIMPOMAA", "PHILOMINA TAWIAH", "GEORGE KWABENA  ANING", "JOHN  KYEI", "ROBERT ASIAMAH", "STEPHEN KWAME AMETOR", "JULIANA MENSAH", "KINGSLEY OFORI ASANTE", "FRANK ODOI", "FRANK GHARTEY", "PADMORE ADDAI", "VICTORIA ADDAI", "COSMOS OWUSU - AFRIYIE", "ADWOA  GYAMFUAH", "DEBORAH DONKOR", "SABINA SONFUL COFFIE", "KOFI BONSU AMANKWAH", "ELIJAH HAMOND", "ISAAC KWABENA YEBOAH", "ISAAC FRIMPONG", "TWUMASI ANKRAH", "MICHAEL OHEMENG", "SAMUEL DEBRAH", "SAMUEL DEBRAH", "RANSFORD KWESI SAARKWAH", "MARK OFORI", "DIANA SAM", "BARBARA SAM", "LORDSON RICHARD  KYEREMEH", "SANDRA SAM", "PRINCE ANTWI", "SAMUEL ADOM GYEKYE", "PHILEMON MENSAH", "Christabel Ama", "AMA BRAGO ", "Kate Nkrumah", "CHARLOTTE BENTIL", "Esi Tawiah", "FELICITY KYEREMEH", "ESTHER NKRUMAH", "DIANA DONKOR", "ESTHER SARPONG", "SARAH BENTIL", "EVELYN ADDO", "FELIX KYERE", "ENOCH KOFI SAARKWAH", "YAW AMUZU", "JOHN NKETIA", "ANTOINETTE SOSU", "VERONICE  BOBIE ANSAH", "EDWARD AKWAH", "KING ONYINA", "ANTHONY NYAMAAH", "MATILDA ONYINA", "AGNES ANOKYE", "GLORIA MENSAH", "LYDIA ACHEAMPONG", "JOHN SOSU", "VICTORIA SOSU", "CORDELIA BOISON", "CONSTANCE BOFFAH", "NANA KOFI ADU", "REBECCA AGYEMANG", "RACHAEL BADU", "ABBA AWOTWE", "VERONICA  BRAGO", "THOMAS KOOMSON", "DAVID AMO", "CHRIS KOFI DEKADJEVI", "FAUSTINA PADI", "MARY KORENKYE", "ESTEPHANIA ACHIAMAA AGYEMANG", "JOSHUA KWARTENG AMPOFO", "IRENE ADU-GYAMFI", "JOYCE  ADOBEA", "CYNTHIA ;OWUSU", "DORIS ABOAGYE", "ANTHONY OWUSU", "THOMAS OSEI TUTU", "ABRAHAM BENSON", "SANDRA APPIAH", "FREDA APPIAH", "JEMIMA ACHEAMPONG", "CYNTHIA AGYEMANG BADU", "ABIGAIL AMOAH", "ELIESER ESHUN", "STEPHEN EBO SAM", "ABIGAIL AGBANYO", "NAOMI OKYEM", "NKRUMAH PETER", "KONADU THERESAH", "EDITH OSAAH AFIA", "PAUL AMANKWAAH", "CHRISTIANA FORKUO NKRUMAH", "ABDELAH HARRIETING", "BRIDGET ANSAH", "MARY DOE", "OPHELIA ARHINFUL", "STEPHEN APPIAH", "MENSAH JOSEPH", "EVELYN ADDO", "ESTHER NKRUMAH", "ESI TAWIAH", "KATE NKRUMAH", "CHRISTABEL AMA", "ALFRED KOJO AFADZI", "BLESSING AKOSUA GADI", "ELIZABETH  QUANSAH", "FLORENCE BOATENG", "ADWOA DUFIE", "EMMANUEL AKYEN ABBAN", "ESTHER GAZIE", "ABA  MANU", "MICHAEL OFORI", "ISAAC FIIFI MENSAH", "PAUL KWASI OWUSU ANSAH", "HAPPY NYATUAME", "GEORGE QUAINOO", "GRACE OPOKU", "GIDEON OPPONG", "GIFT SAPOMAA", "KWAME NKRUMAH", "DIANA ENCHIL", "YAW KUSI", "AKOSUA ABOAGYEWAA", "BISMARK OSEI BONSU", "FRANCIS DUNCAN", "CECILIA MENSAH OWUSU", "CECILIA MENSAH OWUSU", "GLADYS AYEDAN", "COMFORT ARHIN", "VICTORIA OWUSU", "MAXWELL AKYEN ABBAN", "MAXWELL AKYEN ABBAN ", "KWAKU BAAH", "KOFI WILSON", "ELIZABETH TSAHEY", "MERCY ACQUAH", "AMA ANSANBA", "AGNES  MENSAH", "AGNES MENSAH AFARIWA", "MARY GYASI", "VERONICA  BAYABU", "GIFTY BAYABU", "NAOMI AHIABA", "KURUG ZURE", "MERCY  OKRAH", "LYDIA VORMATU", "MARY APAALIE", "JOSEPHINE AGYEKUM", "REGINA MARFO", "SOLOMON ASANTE", "LEIZAR ZIENE", "JACQUELINE DEDE QUAYE ", "NICHOLAS AMEDONU", "SAMUEL KUMAH COFFIE", "MAVIS OPOKU", "HAWA  ANAMAN", "GEORGINA KYERE", "JANET OBENG", "OPHELIA OBENG", "EMMANUEL OBENG MENSAH", "MATILDA OBENG", "BERNICE  OBENG", "ISAAC ADOM", "LYDIA OSEI BONSU", "SUSANNA ACQUAH", "EKUA ANNO ACQUAH", "SETH WILLIAMS OTOO BROWN", "THEODORA AMANKWAA", "ALEXANDER AMOAH", "DIANA AMOAH", "ELIZABETH  OBENG", "OPHELIA BONSU", "ENOCH KWADWO FRIMPONG", "COMFORT  GYIMAH", "ADWOA BANNOAH AMANKWAH", "AKUA NYAMEKYE AMANKWAH", "NANA AMA ADJEI ADU", "EMMANUEL KWAME GYIMAH", "STELLA AMAMOO", "YAW TAWIAH", "MARY ARTHUR", "ANNE HAMMOND", "BEATRICE ANANE", "WILLIAM BONSU", "CHRISTIANA  COFFIE", "AMA BIAH", "VICTORIA MENSAH", "HELENA BOATENMAA", "MATILDA TODOKPONSHI", "PAULINA QUAYSON", "JOHN OFOSU ANIM", "JOSEPH ADDAI BEDIAKO", "PORUSA DONKOH", "MOSES SENIOR MENSAH", "MOSES JUNIOR MENSAH", "DEBORAH OFORI DONKOG", "JACOB NARTEY", "HANNAH AMISSAH", "MARY APPIAH", "EVELYN  NYARKO", "PHILOMENA  AYITEY", "JOHN  ANTWI", "LYDIA KUSI", "DORCAS ABEDU", "FELICIA  AMEDONU", "MICHAEL AMEDONU", "AFIA DARKOWAA", "DORA FOSU", "RANSFORD ODURO", "FRANCISCA OFORI", "VICTORIA KYERE", "NANA OBEYAA ANARFI", "JANET JACKSON", "EMMANUEL NYARKO", "MARTIN OWUSU ANSAH", "MARGARET  BENNIN", "ABIGAIL OHENE AGYEKUM", "SARAH ANNAN", "SAMUEL  TAKYI", "SAMUEL KWASI GADI", "AMA AKYERE", "PATRICIA ANNAN", "REBECCA SOGBO", "EMELIA GYAMFI", "AIKINS TWENEBOA", "JOHN AMEY VORMATU", "AMA NKRUMAH", "JUSTINA NYARKO", "GRACE APPIAH", "FRANZY KWAKU DARKO", "AGNES TAYLOR", "AUGUSTINA EFUA NYARKO", "EMMANUEL JNR MENSAH", "CHARLOTTE DONKOR", "HAGAR OFOSU ANIM", "COMFORT ADZUIK", "ESTHER AGYEMANG", "LYDIA ASARE", "KENNETH KARIKARI", "AMA SERWAA", "JOYCE OSEI", "CYNTHIA AMOAH", "PATRICK ENTSIL", "CYNTHIA  NYARKO", "ALFRED ASARE", "VIVIAN KUFFOUR", "GRACE MENSAH", "SELINA  SARPONG", "MARY ABEKAH", "EMMA AMPONSAH", "ESI BODZIWAA", "DANIEL QUAINOO", "AFIA FRIMPOMAA", "NEHEMIAH NYARKO", "EMMA AMOAKWA", "CHARITY OWUSU ANSAH", "COMFORT NKANSAH", "THERESAH DARKO", "JANET AMOATENG YIADOM", "DOROTHY ODOOM", "JOHN KAY ARTHUR", "ELIZABETH OWUSU", "JAMES NSOR", "GEORGE KWABENA SOSU", "NAOMI TWENEBOAH NSOR", "YAA DANSOWAA BOACHIE", "DORCAS BOACHIE", "BARBARA CUDJOE", "NANA ADWOA ANKAI", "HANAH ARTHUR", "THOMAS CUDJOE", "EMMANUEL SAGOE", "COMFORT  NORTEY", "COMFORT  NORTEY", "DORIS OBENG", "AKUA KROMO", "PATIENCE WORDUJ", "JOHN BADU", "PATIENCE ACHEAMPONG", "JULLIET KARIKARI", "AGNES ACQUAH", "VICTORIA AHIN", "EMMANUEL ABAKAH", "JESSICA ABRAHAM", "MICHAEL FENYI ABRAHAM", "CECILIA QUARCOO", "VERONICA BOAKYE", "ISAAC KYEREMATENG BEDIAKO", "DIANA  NYARKO", "HANSON QUAINOO", "EUNICE NYARKO", "COMFORT ACQUAH", "YAA MANSA", "TALATA PUBILAH", "EDWARD DOE", "MOARDECHAI KOOMSON", "CLEMENT AKYEN ABBAN", "GEORGINA MABOAH", "FRED KOBIA", "APPIAH AMANING KWARTENG", "CECILIA MENSAH", "ALFRED TURKSON", "ALBERT BOATENG ASARE", "BEATRICE ABALO OFORI", "COMFORT BUGYEI", "MARGARET ANTWI", "GLORIA POKUAA", "FLORENCE ASAMOAH", "GRACE ANAKWA", "FELICIA  POKUAAH", "RAINBON ANOKYE", "MARGARET ESHUN", "DIANA NKETIA", "JOHN ENTSIL", "STEPHAN DZIMAH", "ERIC KOJO AMAMOO", "JOE ASSAN", "EVELYN AGYEMANG", "BEATRICE ABALO OFORI", "LINDA AFFUL", "ISHMAEL SMITH", "CONSTANCE QUANSAH SMITH", "KWABENA SARPONG", "THERESA AGBETUSE", "EMMANUEL ESSEL EDUOKU", "MATTHEW ENTSIE", "EMMANUEL SARPONG", "KOFI ASARE BOATENG", "MERCY MENSAH", "EVELYN AGYEMANG", "DANIEL ACQUAH", "JAMES YEBOAH", "PORTIA OSEI BONSU", "JOSEPH AIDOO", "SANDRA BAAH DENKYI", "SELINA SENIOR NYARKO", "ALBERT  MORRISON", "VIVIAN MORRISON", "EMMANUEL ASARE - MENSAH", "NAOMI NYARKO", "KWAKU DANSO ABEAM", "AGNES TALATA NAMLEMNAH", "EMMANUEL AZUMAH NAMLEMNAH", "ISAAC BOISON", "MARVIN KWATSE BOISON", "NTIRI DARKO", "OBED NARTEY", "DAVID AGBANYO", "AMA ACHIAA", "ABA MANU", "PAUL ABBAN AKEY", "JOEL NYARKO", "PORTIA EGHAN", "MICHAEL DEBE", "ALFRED BAAH", "NANA ABA BRUWA", "DORCAS ABEKAH", "ALEX  OBIRI YEBOAH", "DAVID AGBANYO", "EMMANUEL  AMISSAH", "JULIANA BILSON", "ERIC BOAKYE", "MERCY OKWONKO", "AKUA AGYEMANG AMANKWAH", "GLADYS ANTWI", "JANET KARIKARI", "J. K. ADJEI", "RITA OFORI", "JULIANA ESI KYENE", "MARY NTRIWAA", "SAMUEL  KUSI", "WENDY MANSAH OBENG", "JANET ANTOH", "MATTHEW AMOAH ESUMANG", "SAMUEL KOFI FRIMPONG", "JULIANA ABBAN", "LUKMAN SHITTY", "MAVIS AFRA ADDO", "SANDRA BAAH DENKYI", "NANCY NYARKO", "JOSEPH ASIEDU", "SHEILA ASARE-MENSAH", "NUHU BOATENG", "DAVID FOFIE", "FLORENCE MIATTA FORAY", "INUSAH ABAD", "TEIKU ACHEAMPONG", "DANIEL ETSE", "KENNETH MENSAH-BOISON", "PATRICK ASANTE OKYERE", "ROSEMARY NKRUMAH-ANTWI", "ORLANDO JAMES ODURO", "HANNAH OSEI", " ", "DOUGLAS BAAH SIAW", "ALICE LAYIPEA FORAY", "JOSEPH JNR FORAY", "DAVID AFEDO AGBE", "PRINCE OSEI BONSU", "ABRAHAM ACHEAMPONG", "YAW ZORDZI", "PHILIPA  OTENG ANIMAH", "RICHARD OSEI AGYEMANG", "DENNIS NAMLEMNAH AZUMAH", "VIVIAN ARTHUR", "REGINA AFRIYIE", "RICHMOND YAO WILLINGTON", "VICTORIA SEM", "HILLARY NAMLEMNAH", "JULIANA  FIANYO", "CLEMENT NIKABU", "MISTIN NODJO", "TALITHA AMANING KWARTENG", "YEMISI LAWAL", "MARTHA  OPPONG ODURO", "JANET OBENG BOATENG", "OSUJI CHIMOBI", "OBED ADDAI", "YAA FREMA NSOWAH", "JOSEPH FORAY", "AJAYI LAWAL", "ANDREWS AMISSAH", "ENOCH KYERE FRIMPONG", "OBED NARTEY", "JOHN OPOKU ABOSI", "MARGARET  OSEI", "MEDINA BOATENG", "JANET AGYEMANG", "AFIA AFRAKOMA", "BEAULAH TIEKU", "KWAKU DANSO ABEAM", "SELINA NYARKO SENIOR ", "SAMUEL OWUSU - AFRIYIE", "JOSEPHINE KOTSE", "RITA GYIMAH", "HANNAH BAAH", "GRACE YEBOAH", "ANTHONY MENSAH", "GEORGE MYLER DAMTSE", "AKOSUA BOATEMAA DAMTSE", "FRANCIS AMISSAH", "ALBERT ATTAH AGYEMANG - BADU", "ALBERT ATTAH AGYEMANG - BADU", "JOSEPH AHOLU", "PATIENCE KUDEKOR", "CHRISTIANA ASANTEWAA ASIAMAH", "SAMPSON SARPONG", "NANA YAA ASANTEWAA BONSU", "SARAH ACHIAA", "ANDREWS ADJEI", "NADIA OSEI BONSU", "COMFORT KETTY", "FRIMPONG BOATENG", "ALFRED KYERE", "LAWRENCE KWASI OWUSU", "OLIVIA ABRAHAM BENSON", "HANNAH ADWUBI", "SAMUEL AKAAH", "FAUSTINA MANOTIBA", "AGNES KWARTENG", "RICHARD TWENEBOAH", "STANDFORD OWUSU", "PHILOMENA AIDOO", "AFIA SERWAA BONSU", "EMMANUEL ANNOR YEBOAH", "BENJAMIN TEI PARTEY", "LINDA PARTEY KWARTENG", "MYSTIC NAMLEMNAH", "EMELIA OSEI AKOTO ROBERTS", "JOHN LEWIS ROBERTS", "ALEX FRIMPONG", "JUSTUS KYEI", "FRANCIS NODJO", "PATRICIA ANNAN", "SOPHIA ABBAN", "REBECCA  OFFEI", "CONSTANCE QUANSAH SMITH", "MONICA QUAINOO", "AMA TAWIAH", "AGNES ASIRIFI", "JOSEPH KWABENA OBENG", "ANASTASIA AMOAKO", "CECILIA OBENG", "JOYCE ADOM", "MARY QUAINO", "MARTIN AMUDU", "YAA OSAAH", "SAMUEL AMEDONU", "NANCY QUAINOO", "HANNAH BAAH", "COMFORT AHIABA VORMATU", "ELIZABETH SEGOE", "SOLOMON MENSAH", "DORIS BENEWAA", "JEMIMA ABAKAH", "GEORGINA ATAMPULE", "FAUSTINA BRAKO", "FIDELIA DOKLI", "JOSEPH KUSI", "THERESAH AFRIYIE", "JOSEPHINE KYEREMATEN", "JENNIFER LAMISI", "ESTHER TAWIAH", "JOSEPH AMOAKO", "ROSINA MENSAH", "RICHMOND OWUSU", "ROSE OWUSU-DANKWAH", "THERESAH BOAKYE", "DOROTHY KUMI", "ACHEAMPONG  ANDREWS", "AMANING-KWARTENG AUGUSTINE", "ANTWI DEBORAH", "AMOASI JOSEPH", "YIRANBIL GEORGINA", "AKUBA REBECCA", "BOAHEN PETER", "BOAKYE EDITH", "AGYARE NIMOH HARRIET", "AMANING KWARTENG  VIVIAN", "ACHEAMPONG ABIGAIL", "DONKOR SARAH", "COFFIE GLADYS", "FRIMPONG AUGUSTINE", "BAFFOUR APPAU JENNIFER", "YAKA ASIBI", "BAWUAH ALFRED", "MENSAH ENOCH", "OKOKU JOYCE", "MANSA AKUA", "MENSAH GRACE", "OSEI GRACE", "MADAM AKUA  ATAA", "GYAN JOHN", "ANKOMAH RACHEL", "MRS. OFORI LUCY", "OSEI MARY", "APPIAH ELIZABETH", "LARIBA MATILDA", "SERWAA AKUA", "NYARKO ABENA", "OSEI SAKYI KINGSFORD", "ATAA ESI", "FIAKLO MANSAH ADWOA", "MENSAH JULIANA", "ADU PINAMANG ANGELA", "BADASU MARGRET", "DAMPTEY LYDIA", "DADZIE GLADYS", "OTI AGNES", "ANANE AGYARE PAUL", "EDUAFUL PAUL", "AHENKAN ADWOA", "SAGOE CECILIA", "GYLMANO KWABLA", "MENSAH SARAH POKUAA", "AGYEMANG JANET", "MENSAH HANNAH", "DUGAN CHRISTIANA", "OWUSU  JULIANA", "APPIAH GRACE", "BOATENG MENSAH OWUSUWAA", "BOADU SELINA", "ASANTEWAA  VICTORIA", "BOATENG AKWASI", "NYARKO MARY", "AGYEI LYDIA AFRA", "AMANING KWARTENG AGNES", "BOADU GLORIA", "FRIMPONG ISAAC", "ATTAH HANNAH", "YORKE MARY", "TAWIAH ESI", "SAGOE EMMANUEL", "DZIGBORDI  AGBEMAYAH", "AUGUSTINA KONADU-YIADOM", "SYLVIA AKYAA KUSI", "SAMUEL ADDO", "ELIZABETH ADAMU", "FELICIA KOKROKO BRITNEY", "DOROTHY KUMI", "DIANA KYEREMATENG", "FELIX KONADU", "FELICIA BLAY", "ISAAC NYANTAKYI", "CHRISTIAN SEM", "KORANG  YAW", "MENSAH  BENJAMIN KWAME", "LAMISI FAUSTINA", "OBENG AGNES", "MOBIRE MICHAEL", "AFIRIYIE RITA", "MR. DANSO MICHAEL", "MRS. BONSU NAOMI", "OWUSU ANGELINA", "ADUTWUMWAA ABENA", "FORSON CECILIA", "AKENBI  JANET", "ADOBIA ESI", "DUWAA TENNE", "ADOMA AMA", "ADU AGNES", "TAWIAH ELIZABETH", "TOXXU KOFI", "SEFAH  MOSES", "HELETSI JONATHAN", "ADONGO MONICA", "MRS. TAWIAH SARAH", "SERWAA MERCY", "SARPONG NYAME DAVIS", "OPPONG CYNTHIA", "K. ASIEDU COLLINS", "ADDAI COMFORT", "OWUSU EMELIA", "MRS. ENYONAM JULIET", "MRS. BIOH MARY", "MENSAH PATRICIA", "OWUSU TIPAH ELIZABETH", "MENSAH COMFORT", "NAGOB ALICE", "DAZIE PAULINA", "ASHIAVOR JULIANA", "ADDAI MAVIS", "APPIAH OPHELIA", "LARIBA YARO", "EGYIRI VICTORIA", "MR. TAWIAH JOSEPH", "OWUSU AGYEMANG KATE", "AMOAH  PORTIA", "YAW-ACHIASE OSEI", "ADU VERONICA", "OSEI FREMAH ESTHER", "BROBBEY JOSEPH", "MAWULORM KWABENA BONAH", "MAXWELL ADDAI", "STEVE OSEI OWUSU", "GLADYS OWUSU", "VERA OWUSU MENSAH", "CAESAR NODJO MENSAH", "QUAYE COMFORT", "KWARTENG  OWUSU", "BAIDOO ALBERTHA", "AFFUL BILLY PATRICIA", "ANOKYE COMFORT", "MOBIRE MATILDA", "AGYEIWAA ADWOA", "ASIEDU GIFTY", "ANOKYE FREDERICK", "QUAICOE PATRICIA", "FORSON VICTORIA", "NYARKO ABEEKU BISMARK", "KWABENA ALI", "BAFFOUR ANDY APPAU", "OWUSU AKWASI", "BOAKYE GRACE", "BOAKYE YIADOM AUGUSTINA", "DUFIE  AGARTHA", "NOAH KWASI BIOH", "KWABENA ADIYIAH STEPHEN", "VIVIAN OPPONG DUFIE", "MAVIS SERWAH BOATENG", "RUTH NANA AMA KONADU ADDAI", "YAW BUGYEI", "JOSEPH ERZUAH", "MARTIN ATTAH MENSAH", "EBENEZER OWUSU BERKO", "SAMUEL AIDOO", "ABA OBUOBI", "ABIGAIL MENSAH-NODJO", "FELIX OBENG BOATENG", "PRISCILLA OWUSU ANSAH", "KENNETH BOADU", "KENNETH OBUOBI", "FRANCIS OPOKU AGYAPONG", "ALEXANDER NII SOWAH", "ELISHA AYITEY", "ERIC EDMUND LARBI", "CHRISTIANA AYITEY", "VERA ANDOH-ERZUAH", "VERA KYERE FRIMPONG", "JULIANA AKOSUA AMOS", "DORA AFIRIM", "OLIVIA AMEA NARTEY", "HANNAH KWARTENG", "KENNETH ANTWI BOSIAKO", "MERCY NSIAH", "MARY ADOM", "VASTY BOAKYE", "JOSEPH PADI", "ABENA SERWAA", "MARY MENSAH", "JAMES  OWUSU ANTWI", "MARGARET ESHUN", "COMFORT APPAH", "FREDA OWUSU SIAW", "ALICE AGYEI", "OLIVIA FRIMPONG", "ISAAC AMOAH", "PAUL KINSLEY DONKOR", "SAMUEL BOAKYE", "JOHN NYARKO", "JULIANA AMANKWAA", "PASTY  HENEWAA", "RICHARD OSEI ASSIBEY", "ANGELA OFORI MINTAH", "DANIEL JOHNSON", "FRANSCIS ATTA KAKRA", "MARY AFRIYIE", "PRINCE ASEIDU", "EVANS AFRIYIE", "REBECCA ASAMOAH GYAMFI", "ERIC KUMI", "OPHELIA BONSU", "GRACE KWANINH KWARTEMAAH", "VIDA BOAKYE", "ELVIS AGYEI OBENG", "JOHN AMOAH", "FRANCIS APPIAH", "AUGUSTINA BOATENG", "DAVID APPIAH BOATENG", "SOLOMON APPIAH BOATENG", "AKWASI ADUMATTA", "CHARLES ADU", "DANIEL ADOMAKO SARHENE", "ADOMAKOH ANSAH", "NANA GYEMFI VICENT", "PRINCESS ANTWIWAA AIDOO", "MAXWELL KWARTENG", "YAYERA AMEDZRO", "JANET KARIKARI", "YAA KROMOH", "PRINCESS SIKA BOATENG", "HANNAH KWARTENG", "COLLINS KWAME ADJEI", "CHARLOTTE OPPONG", "ALEX IBRAHIM", "RICHARD  DUAH", "KOFI GYASI  NIMAKO", "ELIZABETH GYASI NIMAKO", "CLEMENT KWAME OSEI", "MARY YEBOAH", "STEPHEN ENTSIL ACQUAH", "SAMUEL OWUSU SARPONG", "LAWRENCE OBENG", "SAMUEL  FRIMPONG", "ADWOA ACHEAMPOMAA", "MOSES OSEI", "  PATRICIA OSEI", "EMELIA TEBUA KESSE", "MARY YANKSON", "FELICIA OTENG", "RITA YANKSON", "DOROTHY OTENG", "GEORGE MENSAH", "GIFTY NKUM", "ELIZABETH  SAMPO", "REJOYCE TWENEBOAH KODUAH", "SAMUEL AKANTOR", "JULIANA KONADU ASIRIFE", "ATTA SENIOR AGYEI", "OPOKU - KWARTENG ANING", "LINDA BEDIAKO", "ESI  MANSA", "JOHNSON AMOAH", "REBECCA KATAKA", "SANDRA OSEI DARKWA", "THOMAS OPPONG", "NANCY POKUAH", "TWUMASI ANKRAH", "GRACE ASARE", "KWAKU AYEREBI", "MARGARET DONKOR", "ERNESTINA ASARE", "REGINA OPPONG", "FAUSTINA  OPPONG", "JULIANA AGYAPOMAA DANQUAH", "TAWIAH PHILOMINA", "TWUMASI ANKRAH", "MENSAH CLINTON", "OSEI HANNAH", "KWASI REBECCA", "ABUKARI DANIEL", "ADWOA NKRUMAH", "OSEI TUTU EMMANUEL", "GYAN GRACE", "ABEDU MARGARET", "KPARIB CHRISTIANA", "MRS. AGYARE COMFORT", "DORKZL COMFORT", "OWUSU FRIMPOMAA VICTORIA", "RUTH ABBAN", "ROBERT LAMPTEY", "JANET ADJEI", "WILLIAMS HOYA", "EBENEZER  AMOAKO", "MIRIAM BENEWAA BOATENG", "GILBERT KWAKU AGBANYO", "DEBORAH DONKOR", "ALBERTA MANU", "JULIUS HOCKMAN AMEDONU", "NANA ADU GYAMFI", "NANA ADU GYAMFI", "NANA ADU GYAMFI", "KINGSLEY  OWUSU ANTWI", "AUGUSTINA ANIM", "CHRISTIANA VIDA NINSON", "EBENEZER ATTA NIMO", "JAMES YEBOAH", "LYDIA  AMISSAH", "SOLOMON AMISSAH", "DORA KATAKA", "COMFORT AMEDOE", "CHARLOTTE QUANSAH", "RITA ADWUBI HOYA", "GEORGE KWABENA ANING", "LINDA BEDIAKO", "MICHAEL NKUM", "RITA AYIREBI", "AGYEMAN BADU", "EVELYN SAARKWAH", "DOROTHY ATAA PELS", "ROBERT NAAH", "RICHARD MORRISON", "DANIEL AFRIYIE GYIMAH", "GEROGINA  POKUAA", "NICHOLAS YAW BOAKYE", "GODWIN OWUSU", "MINA OWUSU", "RICHARD TWUMASI", "ARCHIBALD OWARE", "VERA OWARE", "JOSEPHINE OSEI-TUTU", "GLORIA SARPONG OWUSUWAA", "BELINDA ADUSEI SARFOWAAH", "ALEXANDER BANDOH", "PATIENCE SARPONG", "ERNEST APPIAH", "DANIEL AMOATENG", "KWAKU APPIAH", "MARIE ADWOA APPIAH", "GLADYS DANQUA", "RUTH ABBAN", "JUSTICE OSEI", "PRISCILLA SERWAA BOATENG", "CHARLES BOATENG", "APAAH CYNTHIA", "BOACHIE MARY", "KWAAKYE OPHELIA", "OPOKU CHRISTIANA", "AFFUL MARY", "ANTWI BERFTHA", "ADENGO PORTIA", "MR. ABOGO AYAKA", "AMISSAH RICHARD", "ANANE OSEI ROSE", "BAFFOUR AWUAH ANITA", "YEVU HELETSI HENRIETTA", "BOADU FRANCISCA", "AUTHER HANNAH", "TAWIAH AFUA", "NANA ADWOA  ANKAI", "MENSAH ELIZABETH", "GYAMFUA HELENA", "MADAM OSEI ANANE ROSE", "QUAISON AFRED", "MRS. DADZIE MONICA ", "OSEI KERTEN", "OSEI OWUSU PETER", "BIOH ADWOA  BOATEMAAH", "OWUSU BAAH KWAME", "DADZIE AFIA BOATEMAA GLORIA", "BOTWE  PATRICK", "SARKODIE EMMANUEL", "KWASHIE  KINGSLEY", "BROBBEY EASTHER", "BOATENG ISAAC", "OWUSU TIPAH VICTORIA", "AKUA ATTAA", "EDINAM DAVID", "AIDOO FLORENCE", "SALTSON MARY", "ANOKYE KWAME", "GYAMFI JUSTICE", "QUANSAH MERCY", "AGYEMANG  MARY", "FELICIA APPIAH", "ANING MARY", "ALFRED BAAH", "EMMANUEL AKWASI ADUSEI", "BRIGHT OSEI", "JULIANA AMEDO", "CHARITY DORMNYO", "ELIZABETH EMELIA PRAH", "SAVANA  OSEI", "GIFTY ADOMAKO SARHENE", "DANIEL OTENG", "FAUSTINA APPIAH", "PETER AMOANU", "AKOSUA SERWAA", "ATTAA POKUA", "JOYCE AKOSUA SERWAA", "MARY OSEI", "JAMES ADUSEI", "ESI AMA AFRAH", "DANIEL OSEI", "FELICIA MORRISON", "PROSPER BOATENG-HODO", "ELIZABETH BOADU", "YAW OSEI", "MATTHEW  ESUMAN AMOAH", "YAW ANTWI", "PETER SAGOE", "ABIGAIL OWUSU", "ISAAC ADOM", "JOSEPH KWASI FRIMPONG", "JOSEPH KWADWO AKUOKU", "ERNESTINA GYASIWAAH", "AGNES ARTHUR", "VICTORIA ABOAGYE", "MAVIS AMPONSAH", "YAA PINAMANG", "THOMAS DONTOH", "ROSINA KYEREWAA", "DOROTHY AIDOO", "AGNES OPOKU", "AKU GYINADO", "GRACE  BOAMAH", "ABIGAIL  OSEI", "AUGUSTINA AGYEIWAA", "FELICIA OBENG", "LORETTA ODURO", "ANDREWS  OPOKU  ACHEAMPONG", "GEORGE TUFFOUR", "GRACE ADAMS", "RICHARD SARPONG", "BRIDGET ADUWAA BREFO", "AKOSUA POKUAAH", "EMMANUEL  ADJEI", "SYLVESTER ADJEI", "FAUSTINA OWUSU ABOAGYE", "JANET ASARE", "JOSEPH KWABENA TAKYI", "MILLICENT AGYEMANG", "AMA SERWAA ODURO", "AMA ASABA", "DIANA MENSAH", "CECILIA ACKON", "DERRICK ANTWI BOSIAKO", "BEATRICE FORSON", "GEORGINA  BOATENG", "DIANA DOME", "AUGUSTINA  AGYEIWAA", "ESTHER BOAHEMAA", "DENNIS WIAFE-AKENTENG", "HELENA YEBOAH", "BARBARA ODURO", "LETICIA DONTOH", "JAMES KWAKYE", "AGNES OPOKU", "AKUA AFRIYIE ANTWI", "DIANA BOATENG", "EMMANUEL  ODURO", "VERA SEFAH", "JAMES ADOM", "LAADI YAKUBU", "PRISCILLA KARIKARI", "MONICA KOOMSON", "JAMIN LAJO AMINU", "COMFORT ASARE", "BEATRICE AGYEIWAA", "AMA NAANA", "KENNETH DADZIE", "VIDA AMPONG", "AKOSUA MANU", "BISMARK ADJEI", "ALBRIGHT AMANKWAAH ADWUBI", "JULIANA OWUSU", "HANNAH KUSI", "CHRISTABEL AMA", "DELALI ALUSZUKU", "MAVIS OWUSU", "ANGELINA  DONKOR", "GIFTY ESSUMAN AMOAH", "ROBERT QUIST", "FRANCISCA AFIA AGYEMANG", "FELICIA ADDAI", "LINDA ADDAI", "MATTHEW KWAKYE", "JERRY BOATENG", "THERESAH DEDE", "MILIICENT ODURO", "SAMUEL AMOAKO ADJEI", "YAW EFFAH", "JANET EFFAH", "JANET AKUA", "PAUL FOKUO", "FELICIA AGYEMANG", "GODFRED ANTWI BOSIAKO", "THERESAH ANANE", "THOMAS KWAME AGYEMANG", "ROSEMOND AGYENIM BOATENG", "EDWARD ACWUAH", "ANGELA KWARTENG", "MERCY MENSAH", "PHILIP BOATENG", "DORA OWUSU AFRAKOMA", "FREDERICK ABU-BONSRAH", "ABENA LOOSU", "AGNES ABEDU", "EMMANUEL MINTAH", "ABA SEKUM", "PAUL ANAMAN", "JOYCE ASANTE", "AFIA ASANTEWAA", "MIRIAM BOTWE", "EMMANUEL ABBAN", "ALEXANDER AGYEMANG OPOKU", "COMFORT OFFEI", "COMFORT ASARE", "MAAME KYEREWAA ", "FRANK OWUSU", "THERESAH OWUSU", "DANIEL OFORI", "MARTIN FOSU", "YAW LARTEY", "JULIANA WIREKO", "DANIEL SEFA", "ALFEDA SERWAA ATAA", "LAURA AMINU", "SAMUEL OFORI", "DORA AMOAKO", "JOHN GYASI", "GLADYS YEBOAH", "COMFORT ANIMA", "CHRISTIANA NYAMEKYE", "RUTH YAMOAH", "JULIET MENSAH", "AMA MMBROWAH", "SAMUEL EDUFFUL", "REXFORD KWADWO AMANKWAA", "FELICIA OPPONG", "PRINCE DANSO", "GEORGE  BAFFOUR BAWUAH", "JOSIAH JUBIN BADU", "JOHN MENSAH KUSI", "VIDA VIADE", "BEATRICE OWUSU EGYIRI", "EVANS GYAN", "CLEMENT MARFO", "MAXWELL HEHEALOLO", "LUCY BAWUAH"})
        Me.TxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSearch.Location = New System.Drawing.Point(127, 24)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(317, 20)
        Me.TxtSearch.TabIndex = 140
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 19)
        Me.Label16.TabIndex = 139
        Me.Label16.Text = "Search"
        '
        'TxtSeat
        '
        Me.TxtSeat.Location = New System.Drawing.Point(384, 208)
        Me.TxtSeat.Name = "TxtSeat"
        Me.TxtSeat.Size = New System.Drawing.Size(121, 20)
        Me.TxtSeat.TabIndex = 152
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Seat Number"
        '
        'dob
        '
        Me.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob.Location = New System.Drawing.Point(126, 211)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(121, 20)
        Me.dob.TabIndex = 154
        Me.dob.Value = New Date(2020, 8, 18, 18, 5, 10, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Date"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(187, 349)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(106, 23)
        Me.BtnAdd.TabIndex = 155
        Me.BtnAdd.Text = "&Add Member"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txttotal)
        Me.GroupBox1.Controls.Add(Me.Txtmale)
        Me.GroupBox1.Controls.Add(Me.Txtfemale)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblmale)
        Me.GroupBox1.Controls.Add(Me.lblfemale)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(126, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 80)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Count"
        '
        'Txttotal
        '
        Me.Txttotal.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotal.Location = New System.Drawing.Point(293, 45)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.ReadOnly = True
        Me.Txttotal.Size = New System.Drawing.Size(62, 25)
        Me.Txttotal.TabIndex = 159
        '
        'Txtmale
        '
        Me.Txtmale.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmale.Location = New System.Drawing.Point(147, 45)
        Me.Txtmale.Name = "Txtmale"
        Me.Txtmale.ReadOnly = True
        Me.Txtmale.Size = New System.Drawing.Size(62, 23)
        Me.Txtmale.TabIndex = 158
        '
        'Txtfemale
        '
        Me.Txtfemale.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfemale.Location = New System.Drawing.Point(22, 45)
        Me.Txtfemale.Name = "Txtfemale"
        Me.Txtfemale.ReadOnly = True
        Me.Txtfemale.Size = New System.Drawing.Size(63, 23)
        Me.Txtfemale.TabIndex = 157
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = Global.OFKCOCYOUTH.My.Resources.Resources.Bill_25px_1
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(289, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblmale
        '
        Me.lblmale.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmale.Image = Global.OFKCOCYOUTH.My.Resources.Resources.Administrator_Male_25px
        Me.lblmale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblmale.Location = New System.Drawing.Point(143, 20)
        Me.lblmale.Name = "lblmale"
        Me.lblmale.Size = New System.Drawing.Size(78, 19)
        Me.lblmale.TabIndex = 1
        Me.lblmale.Text = "       Male"
        Me.lblmale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfemale
        '
        Me.lblfemale.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfemale.Image = Global.OFKCOCYOUTH.My.Resources.Resources.Administrator_Female_25px
        Me.lblfemale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblfemale.Location = New System.Drawing.Point(6, 20)
        Me.lblfemale.Name = "lblfemale"
        Me.lblfemale.Size = New System.Drawing.Size(95, 19)
        Me.lblfemale.TabIndex = 0
        Me.lblfemale.Text = "       Female"
        Me.lblfemale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(555, 386)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSeat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMemID)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.cGender)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label16)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMemID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents cGender As ComboBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtSeat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblmale As Label
    Friend WithEvents lblfemale As Label
    Friend WithEvents Txttotal As TextBox
    Friend WithEvents Txtmale As TextBox
    Friend WithEvents Txtfemale As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
