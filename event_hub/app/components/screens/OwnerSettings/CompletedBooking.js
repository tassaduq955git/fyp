import React, { Component } from "react";
import {
  StyleSheet,
  TouchableOpacity,
  Text,
  View,
  ScrollView,
  FlatList
} from "react-native";
import { Container, Content } from "native-base";
import { withNavigation } from "react-navigation";
import Icon from "react-native-vector-icons/MaterialIcons";
import InputField from "../../small_components/input_field";
import OneBooking from "../../small_components/OneCompletedBookingOwner";
import {
  widthPercentageToDP as wp,
  heightPercentageToDP as hp
} from "react-native-responsive-screen";
class CompletedBooking extends Component {
  constructor(props) {
    super(props);
    this.state = {
      typeOfBooking: "Completed",
      data: []
      // bookingData: this.props.navigation.state.params.Object
    };
  }
  ApprovedBookingForHall() {
    var url;
    if (global.typeOfCompany === "Hall") {
      url =
        "https://eventhub-api.conveyor.cloud/api/Owner/OwnerCompletedHall?id=" +
        global.id;
    } else if (global.typeOfCompany === "Media") {
      url =
        "https://eventhub-api.conveyor.cloud/api/Media/OwnerCompletedRequestsMedia?id=" +
        global.id;
    } else if (global.typeOfCompany === "Caterer") {
      url =
        "https://eventhub-api.conveyor.cloud/api/Caterer/OwnerCompletedRequestsCaterer?id=" +
        global.id;
    }
    fetch(url, {
      method: "POST",
      headers: new Headers({
        "Content-Type": "application/json"
      })
    })
      .then(res => res.json())
      .catch(error => console.error("Error :", error))
      .then(res => {
        this.setState({ data: res });
        if (this.state.data.length == 0) {
          alert("no booking found");
        }
      });
  }
  componentDidMount() {
    this.ApprovedBookingForHall();
  }

  render() {
    return (
      <View>
        <View style={{ marginLeft: wp("9%") }}>
          <InputField
            iconName="search"
            keyType="email-address"
            placeHolder="Search"
            On_Change_Text={this.handleEmailInput}
          />
        </View>
        <FlatList
          // horizontal={true}
          //showsHorizontalScrollIndicator={false}
          data={this.state.data}
          renderItem={hall => (
            <OneBooking
              hall={hall.item}
              navigation={this.props.navigation}
              status={this.state.typeOfBooking}
            />
          )}
          keyExtractor={(name, index) => index.toString()}
          //  ItemSeparatorComponent={() => (
          //   <View style={{ height: 1, backgroundColor: "#cccccc" }} />
          // )}
        />
      </View>
    );
  }
}

const styles = StyleSheet.create({
  btnContainer: {
    width: 330,
    height: 50,
    borderRadius: 7,
    marginTop: 10,
    fontSize: 16,
    backgroundColor: "green",
    alignItems: "center",
    justifyContent: "center",
    right: 10
  },
  justView: {
    width: 330,
    height: 50,
    borderRadius: 7,
    marginTop: 10,
    fontSize: 16,
    backgroundColor: "green",
    alignItems: "center",
    justifyContent: "center",
    right: 10,
    flexDirection: "row"
  },
  searchButton: {
    textAlign: "center",
    color: "white"
  },
  heading: {
    color: "#00b300",
    marginTop: hp("0.5%"),
    width: wp("100%"),
    paddingLeft: wp("2%"),
    backgroundColor: "#ffffff",
    fontSize: hp("4%")
  }
});

export default withNavigation(CompletedBooking);
