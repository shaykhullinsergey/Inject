﻿using System;

namespace Inject
{
	public interface IImplementedBy<TEntity, TImplemented> : IReturnsMapper
		where TEntity : class
		where TImplemented : class, TEntity
	{
		IReturnsMapper Returns(Func<IContainer, TImplemented> factory);
	}
}
