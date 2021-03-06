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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeInstances_Instance> instances;

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

		public long? TotalCount
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeInstances_Instance
		{

			private string instanceId;

			private string instanceName;

			private string status;

			private string payType;

			private string createdTime;

			private string expireTime;

			private string majorVersion;

			private string engine;

			private bool? isHa;

			private string networkType;

			private string vpcId;

			private string vswitchId;

			private string masterInstanceType;

			private int? masterNodeCount;

			private string masterDiskType;

			private int? masterDiskSize;

			private string coreInstanceType;

			private int? coreNodeCount;

			private string coreDiskType;

			private int? coreDiskSize;

			private string regionId;

			private string zoneId;

			private string coldStorageStatus;

			private string backupStatus;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string MajorVersion
			{
				get
				{
					return majorVersion;
				}
				set	
				{
					majorVersion = value;
				}
			}

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public bool? IsHa
			{
				get
				{
					return isHa;
				}
				set	
				{
					isHa = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VswitchId
			{
				get
				{
					return vswitchId;
				}
				set	
				{
					vswitchId = value;
				}
			}

			public string MasterInstanceType
			{
				get
				{
					return masterInstanceType;
				}
				set	
				{
					masterInstanceType = value;
				}
			}

			public int? MasterNodeCount
			{
				get
				{
					return masterNodeCount;
				}
				set	
				{
					masterNodeCount = value;
				}
			}

			public string MasterDiskType
			{
				get
				{
					return masterDiskType;
				}
				set	
				{
					masterDiskType = value;
				}
			}

			public int? MasterDiskSize
			{
				get
				{
					return masterDiskSize;
				}
				set	
				{
					masterDiskSize = value;
				}
			}

			public string CoreInstanceType
			{
				get
				{
					return coreInstanceType;
				}
				set	
				{
					coreInstanceType = value;
				}
			}

			public int? CoreNodeCount
			{
				get
				{
					return coreNodeCount;
				}
				set	
				{
					coreNodeCount = value;
				}
			}

			public string CoreDiskType
			{
				get
				{
					return coreDiskType;
				}
				set	
				{
					coreDiskType = value;
				}
			}

			public int? CoreDiskSize
			{
				get
				{
					return coreDiskSize;
				}
				set	
				{
					coreDiskSize = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string ColdStorageStatus
			{
				get
				{
					return coldStorageStatus;
				}
				set	
				{
					coldStorageStatus = value;
				}
			}

			public string BackupStatus
			{
				get
				{
					return backupStatus;
				}
				set	
				{
					backupStatus = value;
				}
			}
		}
	}
}
