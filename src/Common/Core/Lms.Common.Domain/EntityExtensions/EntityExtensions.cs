﻿using Lms.Comman.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Lms.Common.Domain.EntityExtensions
{
    public static class EntityExtensions
    {
        private static IHttpContextAccessor _httpContextAccessor;
        public static void Configure(IHttpContextAccessor httpContextAccessor = default)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Create için ICreateEntity interface ile implemente edilmiş 2 nesne arasında gerekli bilgileri diğerine taşır.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="sourceEntity"></param>
        /// <returns></returns>
        public static T ChangeCreatedValues<T>(this T destinationEntity, T sourceEntity) where T : ICreateAuditableEntity
        {
            if (destinationEntity == null || sourceEntity == null)
                return destinationEntity;

            destinationEntity.CreatedDate = sourceEntity.CreatedDate;
            destinationEntity.CreatedById = sourceEntity.CreatedById;
            return destinationEntity;
        }

        /// <summary>
        /// Create için ICreateEntity interface ile implemente edilmiş nesneye gerekli userId ve ip bilgilerini set eder 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static T SetCreatedValues<T>(this T model, Guid userId) where T : ICreateAuditableEntity
        {
            if (model == null)
                return model;

            model.CreatedDate = DateTime.Now;
            model.CreatedById = userId;
            return model;
        }

        /// <summary>
        /// Create için ICreateEntity interface ile implemente edilmiş nesneye gerekli userId ve ip bilgilerini set eder 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static T SetCreatedValues<T>(this T model) where T : ICreateAuditableEntity
        {
            if (model == null)
                return model;
            Guid? userId = GetUserId();
            model.CreatedDate = DateTime.Now;
            model.CreatedById = userId;
            return model;
        }

        /// <summary>
        /// Update için IUpdateEntity interface ile implemente edilmiş nesneye gerekli userId ve ip bilgilerini set eder 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static T SetUpdatedValues<T>(this T model, Guid userId) where T : IUpdateAuditableEntity
        {
            if (model == null)
                return model;

            model.UpdatedDate = DateTime.Now;
            model.UpdatedById = userId;
            return model;
        }

        /// <summary>
        /// Update için IUpdateEntity interface ile implemente edilmiş nesneye gerekli userId ve ip bilgilerini set eder 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static T SetUpdatedValues<T>(this T model) where T : IUpdateAuditableEntity
        {
            if (model == null)
                return model;

            Guid? userId = GetUserId();
            model.UpdatedDate = DateTime.Now;
            model.UpdatedById = userId;
            return model;
        }

        /// <summary>
        /// Delete işlemi için IUpdateEntity interface ile implemente edilmiş nesneye gerekli userId, ip ve Silindimi bilgilerini set eder 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <param name="ip"></param>
        public static T SetDeletedValues<T>(this T model, Guid userId) where T : IDeleteAuditableEntity
        {
            if (model == null)
                return model;

            model.SetUpdatedValues(userId);
            model.IsDeleted = true;
            return model;
        }

        /// <summary>
        /// Delete işlemi için IUpdateEntity interface ile implemente edilmiş nesneye gerekli userId, ip ve Silindimi bilgilerini set eder 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <param name="ip"></param>
        public static T SetDeletedValues<T>(this T model) where T : IDeleteAuditableEntity
        {
            if (model == null)
                return model;

            model.SetUpdatedValues();
            model.IsDeleted = true;
            return model;
        }

        #region private

        /// <summary>
        /// login olmuş kullanıcnın Id sini getiren metot
        /// </summary>
        /// <returns></returns>
        private static Guid? GetUserId()
        {
            Guid? userId = null;
            if (_httpContextAccessor != null)
            {
                //var claims = _httpContextAccessor.HttpContext.User?.Identities?.FirstOrDefault()?.Claims?.ToList();
                //if (claims.Any())
                //{
                //    var userIdStr = claims?.FirstOrDefault(x => x.Type.Equals("userId", StringComparison.OrdinalIgnoreCase))?.Value;
                //    if (!string.IsNullOrEmpty(userIdStr))
                //        userId = new Guid(userIdStr);
                //}
            }
            userId = new Guid("12345678-1234-1234-1234-123456789012");
            return userId;
        }

        /// <summary>
        /// kullanıcnın IP getiren metot
        /// </summary>
        /// <returns></returns>
        private static string GetIp()
        {
            string ip = null;
            if (_httpContextAccessor != null)
                ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();
            return ip;
        }
        #endregion
    }
}
