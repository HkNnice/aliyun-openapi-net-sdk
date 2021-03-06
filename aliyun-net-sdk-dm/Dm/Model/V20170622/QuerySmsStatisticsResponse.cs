/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class QuerySmsStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<QuerySmsStatistics_Stat> data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<QuerySmsStatistics_Stat> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QuerySmsStatistics_Stat
		{

			private string createTime;

			private string requestCount;

			private string successCount;

			private string faildCount;

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string RequestCount
			{
				get
				{
					return requestCount;
				}
				set	
				{
					requestCount = value;
				}
			}

			public string SuccessCount
			{
				get
				{
					return successCount;
				}
				set	
				{
					successCount = value;
				}
			}

			public string FaildCount
			{
				get
				{
					return faildCount;
				}
				set	
				{
					faildCount = value;
				}
			}
		}
	}
}
