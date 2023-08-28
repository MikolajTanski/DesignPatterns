// See https://aka.ms/new-console-template for more information

using Builder;

var builder = new InvoiceBuilder();

builder.SetDate(new DateTime(2023,1,1)).
    SetInvoiceNumber("A1").
    SetVendee("Arrow").
    SetVendor("pleple").
    SetLineItems(new List<string>() {"1","2"});

var invoice = builder.Bulid();

Console.WriteLine(invoice.Vandee);