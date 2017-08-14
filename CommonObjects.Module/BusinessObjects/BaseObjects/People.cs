using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using static CommonObjects.Module.Module.BusinessObjects.BaseObjects.EnumLibrary;
using DevExpress.ExpressApp.Editors;

namespace CommonObjects.Module.Module.BusinessObjects.BaseObjects
{
    [DefaultClassOptions, DefaultProperty("FullName"), CreatableItem(false), NavigationItem(false)]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class People : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public People(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}

        [PersistentAlias("Concat(IsNull([FirstName],''), ' ', IsNull([LastName],''))")]
        [VisibleInDetailView(false)]
        public string FullName
        {
            get
            {
                return (string)EvaluateAlias("FullName");
            }
        }

        string firstName;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [ImmediatePostData]
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                SetPropertyValue("FirstName", ref firstName, value);
            }
        }

        string lastName;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [ImmediatePostData]
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                SetPropertyValue("LastName", ref lastName, value);
            }
        }

        MediaDataObject photo;
        public MediaDataObject Photo
        {
            get
            {
                return photo;
            }
            set
            {
                SetPropertyValue("Photo", ref photo, value);
            }
        }

        Gender gender;
        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                SetPropertyValue("Gender", ref gender, value);
            }
        }

        MaritalStatus maritalStatus;
        public MaritalStatus MaritalStatus
        {
            get
            {
                return maritalStatus;
            }
            set
            {
                SetPropertyValue("MaritalStatus", ref maritalStatus, value);
            }
        }

        DateTime birthDate;
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                SetPropertyValue("BirthDate", ref birthDate, value);
            }
        }

        string address;
        [Size(100)]
        [ModelDefault("RowCount", "3")]
        [EditorAlias(EditorAliases.StringPropertyEditor)]
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                SetPropertyValue("Address", ref address, value);
            }
        }

        string personalEmail;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PersonalEmail
        {
            get
            {
                return personalEmail;
            }
            set
            {
                SetPropertyValue("PersonalEmail", ref personalEmail, value);
            }
        }

        string workEmail;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string WorkEmail
        {
            get
            {
                return workEmail;
            }
            set
            {
                SetPropertyValue("WorkEmail", ref workEmail, value);
            }
        }

        string phone;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                SetPropertyValue("Phone", ref phone, value);
            }
        }

        string mobile;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                SetPropertyValue("Mobile", ref mobile, value);
            }
        }

        string fax;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                SetPropertyValue("Fax", ref fax, value);
            }
        }
    }
}