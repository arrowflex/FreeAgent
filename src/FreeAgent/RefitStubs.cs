﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using FreeAgent.Model;
using Refit;
using System.Text;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}

namespace FreeAgent
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIFreeAgentApi : IFreeAgentApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIFreeAgentApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<AccessResponse> RefreshAccessToken(AccessRequest request)
        {
            var arguments = new object[] { request };
            return (Task<AccessResponse>) methodImpls["RefreshAccessToken"](Client, arguments);
        }

        public virtual Task<AttachmentWrapper> GetAttachment(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task<AttachmentWrapper>) methodImpls["GetAttachment"](Client, arguments);
        }

        public virtual Task DeleteAttachment(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task) methodImpls["DeleteAttachment"](Client, arguments);
        }

        public virtual Task<CompanyWrapper> CompanyDetails(string authorization)
        {
            var arguments = new object[] { authorization };
            return (Task<CompanyWrapper>) methodImpls["CompanyDetails"](Client, arguments);
        }

        public virtual Task<TaxTimelineWrapper> TaxTimelines(string authorization)
        {
            var arguments = new object[] { authorization };
            return (Task<TaxTimelineWrapper>) methodImpls["TaxTimelines"](Client, arguments);
        }

        public virtual Task<BankAccountWrapper> BankAccountList(string authorization,string view)
        {
            var arguments = new object[] { authorization,view };
            return (Task<BankAccountWrapper>) methodImpls["BankAccountList"](Client, arguments);
        }

        public virtual Task<BankAccountWrapper> BankAccount(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task<BankAccountWrapper>) methodImpls["BankAccount"](Client, arguments);
        }

        public virtual Task<BankAccountWrapper> CreateBankAccount(string authorization,BankAccountWrapper account)
        {
            var arguments = new object[] { authorization,account };
            return (Task<BankAccountWrapper>) methodImpls["CreateBankAccount"](Client, arguments);
        }

        public virtual Task<BankAccountWrapper> UpdateBankAccount(string authorization,int id,BankAccountWrapper account)
        {
            var arguments = new object[] { authorization,id,account };
            return (Task<BankAccountWrapper>) methodImpls["UpdateBankAccount"](Client, arguments);
        }

        public virtual Task DeleteBankAccount(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task) methodImpls["DeleteBankAccount"](Client, arguments);
        }

        public virtual Task<BillWrapper> BillList(string authorization,string view)
        {
            var arguments = new object[] { authorization,view };
            return (Task<BillWrapper>) methodImpls["BillList"](Client, arguments);
        }

        public virtual Task<BillWrapper> GetBill(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task<BillWrapper>) methodImpls["GetBill"](Client, arguments);
        }

        public virtual Task<Categories> CategoryList(string authorization)
        {
            var arguments = new object[] { authorization };
            return (Task<Categories>) methodImpls["CategoryList"](Client, arguments);
        }

        public virtual Task<CategoryWrapper> GetCategory(string authorization,string nominalCode)
        {
            var arguments = new object[] { authorization,nominalCode };
            return (Task<CategoryWrapper>) methodImpls["GetCategory"](Client, arguments);
        }

        public virtual Task<InvoiceWrapper> InvoiceList(string authorization,string view,string sort,bool nested_invoice_items)
        {
            var arguments = new object[] { authorization,view,sort,nested_invoice_items };
            return (Task<InvoiceWrapper>) methodImpls["InvoiceList"](Client, arguments);
        }

        public virtual Task<InvoiceWrapper> GetInvoice(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task<InvoiceWrapper>) methodImpls["GetInvoice"](Client, arguments);
        }

        public virtual Task<InvoiceWrapper> CreateInvoice(string authorization,Invoice invoice)
        {
            var arguments = new object[] { authorization,invoice };
            return (Task<InvoiceWrapper>) methodImpls["CreateInvoice"](Client, arguments);
        }

        public virtual Task ChangeInvoiceStatus(string authorization,int id,string transition)
        {
            var arguments = new object[] { authorization,id,transition };
            return (Task) methodImpls["ChangeInvoiceStatus"](Client, arguments);
        }

        public virtual Task<ProjectWrapper> ProjectList(string authorization,string view,string sort)
        {
            var arguments = new object[] { authorization,view,sort };
            return (Task<ProjectWrapper>) methodImpls["ProjectList"](Client, arguments);
        }

        public virtual Task<InvoiceWrapper> GetProject(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task<InvoiceWrapper>) methodImpls["GetProject"](Client, arguments);
        }

        public virtual Task<ContactWrapper> ContactList(string authorization,string view,string sort)
        {
            var arguments = new object[] { authorization,view,sort };
            return (Task<ContactWrapper>) methodImpls["ContactList"](Client, arguments);
        }

        public virtual Task<ContactWrapper> CreateContact(string authorization,ContactWrapper contact)
        {
            var arguments = new object[] { authorization,contact };
            return (Task<ContactWrapper>) methodImpls["CreateContact"](Client, arguments);
        }

        public virtual Task UpdateContact(string authorization,int id,ContactWrapper contact)
        {
            var arguments = new object[] { authorization,id,contact };
            return (Task) methodImpls["UpdateContact"](Client, arguments);
        }

        public virtual Task<ContactWrapper> GetContact(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task<ContactWrapper>) methodImpls["GetContact"](Client, arguments);
        }

        public virtual Task DeleteContact(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task) methodImpls["DeleteContact"](Client, arguments);
        }

        public virtual Task<NoteItemWrapper> NoteList(string authorization,string contact,string project)
        {
            var arguments = new object[] { authorization,contact,project };
            return (Task<NoteItemWrapper>) methodImpls["NoteList"](Client, arguments);
        }

        public virtual Task<NoteItemWrapper> CreateNote(string authorization,NoteItemWrapper note,string contact,string project)
        {
            var arguments = new object[] { authorization,note,contact,project };
            return (Task<NoteItemWrapper>) methodImpls["CreateNote"](Client, arguments);
        }

        public virtual Task UpdateNote(string authorization,int id,NoteItemWrapper contact)
        {
            var arguments = new object[] { authorization,id,contact };
            return (Task) methodImpls["UpdateNote"](Client, arguments);
        }

        public virtual Task<NoteItemWrapper> GetNote(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task<NoteItemWrapper>) methodImpls["GetNote"](Client, arguments);
        }

        public virtual Task DeleteNote(string authorization,int id)
        {
            var arguments = new object[] { authorization,id };
            return (Task) methodImpls["DeleteNote"](Client, arguments);
        }

    }
}


