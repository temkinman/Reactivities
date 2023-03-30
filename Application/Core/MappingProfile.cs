using Domain.Entities;

namespace Application.Core;

using Application.Activities;
using AutoMapper;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<Activity, Activity>();
		CreateMap<Activity, ActivityDto>().
			ForMember(dest => dest.HostUserName, o => o.MapFrom(s => s.Attendees
				.FirstOrDefault(x => x.IsHost).AppUser.UserName));
		CreateMap<ActivityAttendee, Profiles.Profile>()
			.ForMember(d => d.DisplayName, o => o.MapFrom(s => s.AppUser.DisplayName))
			.ForMember(d => d.UserName, o => o.MapFrom(s => s.AppUser.UserName))
			.ForMember(d => d.Bio, o => o.MapFrom(s => s.AppUser.Bio));
	}
}
