using CRM.Protobuf.Contact.V1;
using HotChocolate.Types;

namespace CRM.Graph.Gateway.Types
{
    public class ContactType : ObjectType<Contact>
    {
        protected override void Configure(IObjectTypeDescriptor<Contact> descriptor)
        {
            descriptor.Field(t => t.CalculateSize()).Ignore();
            descriptor.Field(t => t.Clone()).Ignore();
            descriptor.Field(t => t.Equals(null)).Ignore();
        }
    }
}
