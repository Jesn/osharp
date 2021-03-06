﻿// -----------------------------------------------------------------------
//  <copyright file="EntityOutputDtoMapTuple.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2015 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-10-14 2:32</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using OSharp.Core.Mapping;
using OSharp.Core.Security;


namespace OSharp.AutoMapper
{
    /// <summary>
    /// 实体-输出DTO映射配对
    /// </summary>
    public class EntityOutputDtoMapTuple : MapTupleBase<EntityTypeFinder, OutputDtoTypeFinder>
    {
        /// <summary>
        /// 重写以定义源类型与目标类型的匹配规则
        /// </summary>
        /// <param name="sourceType">源类型</param>
        /// <param name="targetType">目标类型</param>
        /// <returns></returns>
        protected override bool IsMatch(Type sourceType, Type targetType)
        {
            const string end = "OutputDto";
            return sourceType.Name + end == targetType.Name;
        }

        /// <summary>
        /// 重写以实现映射类型的创建
        /// </summary>
        /// <param name="sourceType">源类型</param>
        /// <param name="targetType">目标类型</param>
        protected override void CreateMapper(Type sourceType, Type targetType)
        {
            Mapper.CreateMap(sourceType, targetType);
        }
    }
}