;#DropDB CIPortalEasyTest

#Application CIPortal.Win
#Application CIPortal.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef CIPortal.Win

*Action About...
 
*Action OK

#EndIf

#IfDef CIPortal.Web
*Action Navigation(My Details)
#EndIf
