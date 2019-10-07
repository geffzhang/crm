using CRM.Protobuf.Contacts.V1;
using HotChocolate.Types;

namespace CRM.Graph.Gateway.Types
{
    public class ContactInputType : InputObjectType<CreateContactRequest>
    {
        protected override void Configure(IInputObjectTypeDescriptor<CreateContactRequest> descriptor)
        {
            descriptor.Name("ContactInput");
        }
    }
}
