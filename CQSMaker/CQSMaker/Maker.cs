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
            string result = @"
using FluentValidation;
using MediatR;
using System.Collections;

namespace @project.Features.@featureFeature.@types
{
    public class @name@type : IRequest<@nameResponse>
    {

    }

    public class @nameResponse
    {

    }

    public class @nameHandler : IRequestHandler<@name@type, @nameResponse>
    {
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
    }

    public class @name@typeValidator : AbstractValidator<@name@type>
    {
        public @name@typeValidator() 
        {

        }
    }
}
            ";

            if (responseList)
                result =
                    result
                    .Replace("<@nameResponse>", "<IEnumerable<@nameResponse>>")
                    .Replace(", @nameResponse>", ", IEnumerable<@nameResponse>>");

            return result
                .Replace("@name", name)
                .Replace("@project", project)
                .Replace("@type", type)
                .Replace("@feature", feature);
        }
    }
}
