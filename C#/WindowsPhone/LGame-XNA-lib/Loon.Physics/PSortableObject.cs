/// <summary>
/// Copyright 2013 The Loon Authors
/// Licensed under the Apache License, Version 2.0 (the "License"); you may not
/// use this file except in compliance with the License. You may obtain a copy of
/// the License at
/// http://www.apache.org/licenses/LICENSE-2.0
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
/// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
/// License for the specific language governing permissions and limitations under
/// the License.
/// </summary>
///
namespace Loon.Physics {
	
	public class PSortableObject {
	
		internal PSortableAABB aabb;
		internal bool begin;
		internal PShape parent;
		internal float value_ren;
	
		public PSortableObject(PShape s, PSortableAABB a, float v,
				bool b) {
			this.parent = s;
			this.aabb = a;
			this.value_ren = v;
			this.begin = b;
		}
	
	}
}
