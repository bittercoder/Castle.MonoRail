// Copyright 2004-2011 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.MonoRail.Framework.Test
{
	using System.Collections.Generic;

	/// <summary>
	/// Exposes methods on top of <see cref="IViewComponentContext"/>
	/// that are used by unit tests
	/// </summary>
	public interface IMockViewComponentContext : IViewComponentContext
	{
		/// <summary>
		/// Gets or sets the section render dictionary.
		/// </summary>
		/// <value>The section render.</value>
		IDictionary<string, TestSectionRender> SectionRender { get; set; }
	}
}