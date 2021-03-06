﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = Trinity.Hotfix.IFsm;

namespace Trinity.Hotfix
{
    public class ProcedureHotfixEntry : ProcedureBase
    {
        protected internal override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            Log.Info("进入了热更新入口流程");

            //TODO:在这里切换到游戏的正式开始场景，场景编号可在DefaultConfig中配置
            procedureOwner.SetData<VarInt>(Trinity.Constant.ProcedureData.NextSceneId, GameEntry.Config.GetInt("Scene.Test"));
            ChangeState<ProcedureChangeScene>(procedureOwner);
        }
    }
}

