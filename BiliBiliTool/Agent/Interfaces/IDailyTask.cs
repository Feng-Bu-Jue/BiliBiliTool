﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace BiliBiliTool.Agent.Interfaces
{
    /// <summary>
    /// BiliBili每日任务相关接口
    /// </summary>
    public interface IDailyTaskApi
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [Get("/x/web-interface/nav")]
        Task<BiliApiResponse<LoginResponse>> LoginByCookie();

        /// <summary>
        /// 获取每日任务的完成情况
        /// </summary>
        /// <returns></returns>
        [Get("/x/member/web/exp/reward")]
        Task<BiliApiResponse<DailyTaskInfo>> GetDailyTaskRewardInfo();

        /// <summary>
        /// 获取某分区下X日内排行榜
        /// </summary>
        /// <param name="rid"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        [Get("/x/web-interface/ranking/region?rid={rid}&day={day}")]
        Task<BiliApiResponse<List<RankingInfo>>> GetRegionRankingVideos(int rid, int day);

        /// <summary>
        /// 上传视频观看进度
        /// </summary>
        /// <returns></returns>
        [Post("/x/click-interface/web/heartbeat?aid={aid}&played_time={playedTime}")]
        Task<BiliApiResponse> UploadVideoHeartbeat(string aid, int playedTime);

        /// <summary>
        /// 分享视频
        /// </summary>
        /// <param name="aid"></param>
        /// <param name="csrf"></param>
        /// <returns></returns>
        [Post("/x/web-interface/share/add?aid={aid}&csrf={csrf}")]
        Task<BiliApiResponse> ShareVideo(string aid, string csrf);
    }
}
