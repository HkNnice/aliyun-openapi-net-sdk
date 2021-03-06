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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class ModifySmartAccessGatewayRequest : RpcAcsRequest<ModifySmartAccessGatewayResponse>
    {
        public ModifySmartAccessGatewayRequest()
            : base("Smartag", "2018-03-13", "ModifySmartAccessGateway", "smartag", "openAPI")
        {
        }

		private List<SnatEntries> snatEntriess;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string description;

		private long? ownerId;

		private int? securityLockThreshold;

		private string name;

		private string cidrBlock;

		private string smartAGId;

		public List<SnatEntries> SnatEntriess
		{
			get
			{
				return snatEntriess;
			}

			set
			{
				snatEntriess = value;
				for (int i = 0; i < snatEntriess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SnatEntries." + (i + 1) + ".CidrBlock", snatEntriess[i].CidrBlock);
					DictionaryUtil.Add(QueryParameters,"SnatEntries." + (i + 1) + ".SnatIp", snatEntriess[i].SnatIp);
				}
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? SecurityLockThreshold
		{
			get
			{
				return securityLockThreshold;
			}
			set	
			{
				securityLockThreshold = value;
				DictionaryUtil.Add(QueryParameters, "SecurityLockThreshold", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string CidrBlock
		{
			get
			{
				return cidrBlock;
			}
			set	
			{
				cidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "CidrBlock", value);
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGId", value);
			}
		}

		public class SnatEntries
		{

			private string cidrBlock;

			private string snatIp;

			public string CidrBlock
			{
				get
				{
					return cidrBlock;
				}
				set	
				{
					cidrBlock = value;
				}
			}

			public string SnatIp
			{
				get
				{
					return snatIp;
				}
				set	
				{
					snatIp = value;
				}
			}
		}

        public override ModifySmartAccessGatewayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySmartAccessGatewayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
