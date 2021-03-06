import React, { Component } from "react";
import { Container, Header, Content, Button, Text, View } from "native-base";
import { StyleSheet } from "react-native";
import {
  widthPercentageToDP as wp,
  heightPercentageToDP as hp
} from "react-native-responsive-screen";
export default class extends Component {
  render() {
    return (
      <View>
        <Text style={styles.packegesText}>Facilities</Text>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#eaeae1",
    // marginTop: hp("5%"),
    width: wp("100%"),
    height: hp("5%")
  },
  packegesText: {
    color: "#00b300",
    marginTop: hp("0.5%"),
    width: wp("100%"),
    //marginLeft: wp("2%"),
    backgroundColor: "#ffffff",
    // position: "absolute",
    fontSize: hp("4%")
  }
});
