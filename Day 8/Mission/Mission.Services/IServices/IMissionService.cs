﻿using Mission.Entities.Models.CommonModel;
using Mission.Entities.Models.MissionsModels;

namespace Mission.Services.IServices
{
    public interface IMissionService
    {
        List<MissionResponseModel> GetMissionList();
        MissionResponseModel GetMissionById(int missionId);
        string DeleteMission(int missionId);
        string AddMission(AddMissionRequestModel request);
        List<MissionResponseModel> ClientMissionList(int userId);

        Task<bool> UpdateMission(MissionRequestViewModel model);
        List<DropDownResponseModel> MissionThemeList();

        List<DropDownResponseModel> MissionSkillList();

        string ApplyMission(ApplyMissionRequestModel request);
        string ApproveMission(int id);
        List<MissionApplicationResponseModel> MissionApplicationList();
        string DeleteMissionApplication(int id);
    }
}
