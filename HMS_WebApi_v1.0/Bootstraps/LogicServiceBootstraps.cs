﻿using Microsoft.Extensions.DependencyInjection.Extensions;
using Repository.Repo;

namespace HMS_WebApi_v1._0.Bootstraps
{
    public static class LogicServiceBootstraps
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.TryAddScoped<IPatientRepo, PatientRepo>();
            services.TryAddScoped<IAppointmentRepo, AppointmentRepo>();
            services.TryAddScoped<IRegisteredAppointment, RegisteredAppointmentRepo>();
            services.TryAddScoped<ICodesRepo, CodesRepo>();
            return services;
        }
    }
}
