using CRM.Protobuf.Contacts.V1;
using MediatR;

namespace CRM.Contact.Queries
{
    public class FindAllContactsQuery : IRequest<ListContactsResponse>
    {

    }
}
