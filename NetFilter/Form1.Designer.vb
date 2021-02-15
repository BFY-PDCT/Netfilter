Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.sitetxt = New System.Windows.Forms.TextBox()
        Me.INFO_GEN_2 = New System.Windows.Forms.Label()
        Me.APPEND = New System.Windows.Forms.Button()
        Me.UNBLOCK = New System.Windows.Forms.Button()
        Me.PGNAME = New System.Windows.Forms.Label()
        Me.VERSTR = New System.Windows.Forms.Label()
        Me.INFO_GEN_1 = New System.Windows.Forms.Label()
        Me.APPLY = New System.Windows.Forms.Button()
        Me.Bar = New System.Windows.Forms.Label()
        Me.QUIT = New System.Windows.Forms.Button()
        Me.INFO_WARN_1 = New System.Windows.Forms.Label()
        Me.EDITING = New System.Windows.Forms.Label()
        Me.APPLIED = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(12, 134)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(776, 376)
        Me.ListBox1.TabIndex = 0
        '
        'sitetxt
        '
        Me.sitetxt.Location = New System.Drawing.Point(15, 106)
        Me.sitetxt.MaxLength = 1000
        Me.sitetxt.Name = "sitetxt"
        Me.sitetxt.Size = New System.Drawing.Size(324, 21)
        Me.sitetxt.TabIndex = 1
        '
        'INFO_GEN_2
        '
        Me.INFO_GEN_2.AutoSize = True
        Me.INFO_GEN_2.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.INFO_GEN_2.Location = New System.Drawing.Point(13, 91)
        Me.INFO_GEN_2.Name = "INFO_GEN_2"
        Me.INFO_GEN_2.Size = New System.Drawing.Size(767, 12)
        Me.INFO_GEN_2.TabIndex = 2
        Me.INFO_GEN_2.Text = "차단할 사이트를 입력해주세요 (예시 : www.youtube.com, 주의 : 유효하지 않은 사이트 주소를 입력하여 생기는 피해는 책임지지 않습니" &
    "다.)"
        '
        'APPEND
        '
        Me.APPEND.Location = New System.Drawing.Point(345, 105)
        Me.APPEND.Name = "APPEND"
        Me.APPEND.Size = New System.Drawing.Size(75, 23)
        Me.APPEND.TabIndex = 3
        Me.APPEND.Text = "추가"
        Me.APPEND.UseVisualStyleBackColor = True
        '
        'UNBLOCK
        '
        Me.UNBLOCK.Location = New System.Drawing.Point(619, 105)
        Me.UNBLOCK.Name = "UNBLOCK"
        Me.UNBLOCK.Size = New System.Drawing.Size(169, 23)
        Me.UNBLOCK.TabIndex = 4
        Me.UNBLOCK.Text = "선택한 사이트 차단 해제"
        Me.UNBLOCK.UseVisualStyleBackColor = True
        '
        'PGNAME
        '
        Me.PGNAME.AutoSize = True
        Me.PGNAME.Font = New System.Drawing.Font("굴림", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PGNAME.Location = New System.Drawing.Point(12, 38)
        Me.PGNAME.Name = "PGNAME"
        Me.PGNAME.Size = New System.Drawing.Size(252, 43)
        Me.PGNAME.TabIndex = 5
        Me.PGNAME.Text = "NETFILTER"
        '
        'VERSTR
        '
        Me.VERSTR.AutoSize = True
        Me.VERSTR.Font = New System.Drawing.Font("굴림", 15.0!)
        Me.VERSTR.Location = New System.Drawing.Point(270, 61)
        Me.VERSTR.Name = "VERSTR"
        Me.VERSTR.Size = New System.Drawing.Size(51, 20)
        Me.VERSTR.TabIndex = 6
        Me.VERSTR.Text = "Vx.x"
        '
        'INFO_GEN_1
        '
        Me.INFO_GEN_1.AutoSize = True
        Me.INFO_GEN_1.Location = New System.Drawing.Point(343, 38)
        Me.INFO_GEN_1.Name = "INFO_GEN_1"
        Me.INFO_GEN_1.Size = New System.Drawing.Size(373, 24)
        Me.INFO_GEN_1.TabIndex = 7
        Me.INFO_GEN_1.Text = "시스템 파일 수정 방식으로 프로그램을 종료해도 차단이 유지됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "차단내용을 적용시킨 뒤에는 브라우저 등을 재시작해주세요"
        '
        'APPLY
        '
        Me.APPLY.Location = New System.Drawing.Point(426, 105)
        Me.APPLY.Name = "APPLY"
        Me.APPLY.Size = New System.Drawing.Size(75, 23)
        Me.APPLY.TabIndex = 8
        Me.APPLY.Text = "적용"
        Me.APPLY.UseVisualStyleBackColor = True
        '
        'Bar
        '
        Me.Bar.AutoSize = True
        Me.Bar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bar.Font = New System.Drawing.Font("굴림", 15.0!)
        Me.Bar.Location = New System.Drawing.Point(0, 0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(800, 20)
        Me.Bar.TabIndex = 10
        Me.Bar.Text = "                                                                                 " &
    "                                "
        '
        'QUIT
        '
        Me.QUIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.QUIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.QUIT.Location = New System.Drawing.Point(713, 65)
        Me.QUIT.Name = "QUIT"
        Me.QUIT.Size = New System.Drawing.Size(75, 23)
        Me.QUIT.TabIndex = 11
        Me.QUIT.Text = "종료"
        Me.QUIT.UseVisualStyleBackColor = False
        '
        'INFO_WARN_1
        '
        Me.INFO_WARN_1.AutoSize = True
        Me.INFO_WARN_1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.INFO_WARN_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.INFO_WARN_1.Location = New System.Drawing.Point(456, 70)
        Me.INFO_WARN_1.Name = "INFO_WARN_1"
        Me.INFO_WARN_1.Size = New System.Drawing.Size(251, 12)
        Me.INFO_WARN_1.TabIndex = 12
        Me.INFO_WARN_1.Text = "반드시 적용 버튼을 누른 뒤 종료해주세요"
        '
        'EDITING
        '
        Me.EDITING.AutoSize = True
        Me.EDITING.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EDITING.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EDITING.Location = New System.Drawing.Point(507, 110)
        Me.EDITING.Name = "EDITING"
        Me.EDITING.Size = New System.Drawing.Size(44, 12)
        Me.EDITING.TabIndex = 13
        Me.EDITING.Text = "수정중"
        '
        'APPLIED
        '
        Me.APPLIED.AutoSize = True
        Me.APPLIED.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.APPLIED.ForeColor = System.Drawing.Color.Lime
        Me.APPLIED.Location = New System.Drawing.Point(557, 110)
        Me.APPLIED.Name = "APPLIED"
        Me.APPLIED.Size = New System.Drawing.Size(44, 12)
        Me.APPLIED.TabIndex = 14
        Me.APPLIED.Text = "적용됨"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 523)
        Me.Controls.Add(Me.APPLIED)
        Me.Controls.Add(Me.EDITING)
        Me.Controls.Add(Me.INFO_WARN_1)
        Me.Controls.Add(Me.QUIT)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.APPLY)
        Me.Controls.Add(Me.INFO_GEN_1)
        Me.Controls.Add(Me.VERSTR)
        Me.Controls.Add(Me.PGNAME)
        Me.Controls.Add(Me.UNBLOCK)
        Me.Controls.Add(Me.APPEND)
        Me.Controls.Add(Me.INFO_GEN_2)
        Me.Controls.Add(Me.sitetxt)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "NETFILTER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents sitetxt As TextBox
    Friend WithEvents INFO_GEN_2 As Label
    Friend WithEvents APPEND As Button
    Friend WithEvents UNBLOCK As Button
    Friend WithEvents PGNAME As Label
    Friend WithEvents VERSTR As Label
    Friend WithEvents INFO_GEN_1 As Label
    Friend WithEvents APPLY As Button
    Friend WithEvents Bar As Label
    Friend WithEvents QUIT As Button
    Friend WithEvents INFO_WARN_1 As Label
    Friend WithEvents EDITING As Label
    Friend WithEvents APPLIED As Label
End Class
