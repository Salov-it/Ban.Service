﻿using FluentValidation;
using MediatR;

namespace Ban.Application.Common.Behaviors
{
    internal class ValidationBehavior<TRequest, TResponse>
       // : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(
           TRequest request,
           RequestHandlerDelegate<TResponse> next,
           CancellationToken cancellationToken
           )
        {
            var context = new ValidationContext<TRequest>(request);
            var failtures = _validators
                .Select(v => v.Validate(context))
                .SelectMany(res => res.Errors)
                .Where(fail => fail != null)
                .ToList();
            if (failtures.Count != 0)
            {
                throw new ValidationException(failtures);
            }
            return next();
        }
    }
}
