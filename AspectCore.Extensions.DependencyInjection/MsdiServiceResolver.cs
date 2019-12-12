﻿using System;
#if NET451
using AspectCore.DependencyInjection;

#else
using AspectCore.Injector;

#endif

namespace AspectCore.Extensions.DependencyInjection {
    internal class MsdiServiceResolver : IServiceResolver {
        private readonly IServiceProvider _serviceProvider;

        public MsdiServiceResolver(IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }

        public void Dispose() {
            var d = _serviceProvider as IDisposable;
            d?.Dispose();
        }

        public object GetService(Type serviceType) {
            return _serviceProvider.GetService(serviceType);
        }

        public object Resolve(Type serviceType) {
            return _serviceProvider.GetService(serviceType);
        }
    }
}