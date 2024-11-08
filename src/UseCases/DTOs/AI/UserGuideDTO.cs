namespace Cheetah.UseCases.DTOs.AI;

public record UserGuideDTO(
    long Id,
    string Subject,
    string Description,
    string Keywords,
    string Body);
