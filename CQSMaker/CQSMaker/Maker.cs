using System.Text;

namespace CQSMaker
{
    public static class Maker
    {
        public static string CreateCommand
        (
            string name,
            string project,
            string type,
            string feature,
            bool responseList
        )
        {
            bool command = IsCommand(type);

            StringBuilder result = new StringBuilder();

            result.Append(GetUsings());
            result.Append(GetNamespace(command));
            result.Append(GetRequest(command));
            result.Append(GetResponse());
            result.Append(GetHandler());
            result.Append(GetValidator(command));

            //string result =
            //    GetUsings() +
            //    GetNamespace(command) +
            //    GetRequest(command) +
            //    GetResponse() +
            //    GetHandler() +
            //    GetValidator(command);

            if (responseList)
                result =
                    result
                    .Replace("<@nameResponse>", "<IEnumerable<@nameResponse>>")
                    .Replace(", @nameResponse>", ", IEnumerable<@nameResponse>>");

            return result
                .Replace("@name", name)
                .Replace("@project", project)
                .Replace("@type", type)
                .Replace("@feature", feature)
                .Replace(".Query", ".Querie")
                .ToString();
        }

        private static string GetUsings()
            =>
@"using FluentValidation;
using MediatR;
using @project.Api.Helpers;
using @project.Domain;
using @project.Repositories;";

        private static string GetNamespace(bool command)
            => @"

namespace @project.Api.Features.@featureFeature." + (command ? "Commands" : "Queries") + @"
{";

        private static string GetRequest(bool command)
        {
            return @"
    public class @name@type : IRequest<@nameResponse>
    {
        " + (command ? "internal Guid UsuarioLogadoId { get; set; }" : "") + @"
    }";
        }


        private static string GetResponse()
            => @"

    public class @nameResponse
    {
        public Guid Id { get; set; }
    }";

        private static string GetHandler()
            => @"

    public class @nameHandler : IRequestHandler<@name@type, @nameResponse>
    {
        private readonly IRepository<@feature> _repository;

        public async Task<@nameResponse> Handle
        (
            @name@type request,
            CancellationToken cancellationToken
        )
        {
            ArgumentNullException.ThrowIfNull
            (
                request,
                MessageHelper.NullFor<@name@type>()
            );

            return new @nameResponse();
        }
    }";

        private static string GetValidator(bool command)
        {
            return @"

    public class @name@typeValidator : AbstractValidator<@name@type>
    {
        public @name@typeValidator()
        { 
            " + (command ?
            @"RuleFor(item => item.UsuarioLogadoId)
                .NotEmpty()
                .WithMessage(MessageHelper.EmptyFor<@name@type>(item => item.UsuarioLogadoId));"
            : "") + @"
        }
    }
}";
        }

        private static bool IsCommand(string type)
            => type.Equals("Command");
    }
}
