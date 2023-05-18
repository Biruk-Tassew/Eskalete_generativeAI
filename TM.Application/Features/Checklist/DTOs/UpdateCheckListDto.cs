using TM.Application.Features.Common;

namespace TM.Application.Features.Checklist.DTOs
{
    public class UpdateCheckListDto :BaseDto, ICheckListDto
    {
        
        public string Title { get; set; }

        
        public string Description { get; set; }

        public bool Status { get; set; }
    }
}