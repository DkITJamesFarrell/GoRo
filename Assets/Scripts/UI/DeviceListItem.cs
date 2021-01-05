﻿using UnityEngine;

using TMPro;
using System;

public class DeviceListItem : MonoBehaviour
{
    public static int DeviceListItemID = 0;

    public int DeviceID;
    public TMP_Text DeviceName;
    public TMP_Text DeviceAddress;
    public TMP_Text DeviceStatus;
    public bool Connected;

    private PMCommunication PMCommunication;

    public void SetUp(DeviceObject device)
    {
        PMCommunication = FindObjectOfType<PMCommunication>();

        DeviceID = DeviceListItemID;

        DeviceName.text = device.Name;
        DeviceAddress.text = device.Address;
        DeviceStatus.text = device.Status;

        Connected = false;

        DeviceListItemID++; 
    }

    public void OnConnectClick(DeviceListItem deviceListItem)
    {
        PMCommunication.OnConnectClick(deviceListItem);
    }

    public void Connect()
    {
        DeviceStatus.text = "Connected";
        Connected = true;
    }

    public void Disconnect()
    {
        DeviceStatus.text = "Disconnected";
        Connected = false;
    }
}