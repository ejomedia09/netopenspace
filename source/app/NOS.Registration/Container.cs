using System;
using System.Collections.Generic;

using StructureMap;

namespace NOS.Registration
{
	public static class Container
	{
		public static void BootstrapStructureMap()
		{
			ObjectFactory.Initialize(x => x.Scan(y =>
				{
					y.TheCallingAssembly();
					y.LookForRegistries();
				}));
		}

		public static T GetInstance<T>()
		{
			if (String.IsNullOrEmpty(ObjectFactory.Profile))
			{
				BootstrapStructureMap();
			}

			return ObjectFactory.GetInstance<T>();
		}

		public static IList<T> GetAllInstances<T>()
		{
			if (String.IsNullOrEmpty(ObjectFactory.Profile))
			{
				BootstrapStructureMap();
			}

			return ObjectFactory.GetAllInstances<T>();
		}

		public static void Release()
		{
			ObjectFactory.Container.Dispose();
		}
	}
}