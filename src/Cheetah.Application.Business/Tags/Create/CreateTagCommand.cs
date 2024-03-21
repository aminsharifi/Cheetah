using Ardalis.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah.Application.Business.Tags.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateTagCommand(string Name, string DisplayName) : Ardalis.SharedKernel.ICommand<Result<long>>;