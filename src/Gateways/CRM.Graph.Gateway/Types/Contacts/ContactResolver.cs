using System;
using System.Collections.Generic;
using CRM.Protobuf.Contacts.V1;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.ClientFactory;
using Microsoft.Extensions.Logging;
using static CRM.Protobuf.Contacts.V1.ContactApi;

namespace CRM.Graph.Gateway.Types.Contacts
{
    public class ContactResolver
    {
        private readonly ContactApiClient _contactClient;
        private readonly ILogger<ContactResolver> _logger;

        public ContactResolver(GrpcClientFactory clientFactory, ILoggerFactory loggerFactory)
        {
            _contactClient = clientFactory.CreateClient<ContactApiClient>(nameof(ContactApiClient));
            _logger = loggerFactory.CreateLogger<ContactResolver>();
        }

        public IList<Contact> ListContacts()
        {
            var metaData = new Metadata();
            var result = _contactClient.ListContacts(new Empty(), metaData);
            _logger.LogInformation(result.Contacts.ToString());
            return result.Contacts;
        }

        public Contact GetContactById(Guid contactId)
        {
            var metaData = new Metadata();
            var result = _contactClient.GetContact(new GetContactRequest { ContactId = contactId.ToString() }, metaData);
            return result;
        }

        public Contact CreateNewContact(CreateContactRequest contact)
        {
            var metaData = new Metadata();
            var result = _contactClient.CreateContact(contact);
            return result.Contact;
        }
    }
}
